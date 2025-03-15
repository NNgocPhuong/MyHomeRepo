using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IOrderPaymentService
    {
        Task<decimal> CalculateTotalAmount(int orderId);

        Task<bool> ProcessPaymentAsync(int orderId, string paymentMethod);
    }
}
