using Domain.Entities;
using System;
using System.Collections.Generic;
using Domain.Interfaces;
using Application.IServices;

namespace Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> _roomRepository;

        public RoomService(IRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task AddRoomAsync(Room room)
        {
            await _roomRepository.AddAsync(room);
        }

        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _roomRepository.GetAllAsync();
        }

        public async Task<Room?> GetRoomByIdAsync(int id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }

        public async Task UpdateRoomAsync(Room room)
        {
            await _roomRepository.UpdateAsync(room);
        }
    }
}
