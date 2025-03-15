using Application.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderPaymentService : IOrderPaymentService
    {
        private readonly IOrdersService _orderService;

        public OrderPaymentService(IOrdersService orderService)
        {
            _orderService = orderService;
        }
        public async Task<decimal> CalculateTotalAmount(int orderId)
        {
            var order = await _orderService.GetByIdAsync(orderId);
            if (order == null) throw new Exception("Order not found");

            decimal totalAmount = 0;
            var roomUsage = order.RoomUsage;
            if(roomUsage.EndTime.HasValue)
            {
                TimeSpan duration = roomUsage.EndTime.Value - roomUsage.StartTime;
                totalAmount += roomUsage.Room.PricePerHour * (decimal)duration.TotalHours;
            }

            //Tính tiền thuê nhân viên
            foreach (var detail in order.OrderDetails)
            {
                if(detail.EmployeeId.HasValue)
                {
                    if (detail.StartTime.HasValue && detail.EndTime.HasValue)
                    {
                        TimeSpan employeeDuration = detail.EndTime.Value - detail.StartTime.Value;
                        totalAmount += detail.UnitPrice * (decimal)employeeDuration.TotalHours;
                    }
                }
                else
                {
                    totalAmount += detail.UnitPrice * detail.Quantity.Value;
                }
            }
            return totalAmount;
        }

        public async Task<bool> ProcessPaymentAsync(int orderId, string paymentMethod)
        {
            var order = await _orderService.GetByIdAsync(orderId);
            if (order == null) throw new Exception("Order not found");
            order.PaymentMethod = paymentMethod;
            order.TotalAmount = await CalculateTotalAmount(orderId);
            order.IsPaid = true;
            await _orderService.UpdateAsync(order);
            return true;
        }

    }
}
