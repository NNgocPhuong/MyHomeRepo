using System.Diagnostics;
using System.Threading.Tasks;
using Application.IServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRoomService _roomService;
    public HomeController(ILogger<HomeController> logger, IRoomService roomService)
    {
        _logger = logger;
        _roomService = roomService;
    }

    public async Task<IActionResult> Index()
    {
        var rooms = await _roomService.GetAllRoomsAsync();
        var roomModels = rooms.Select(room => new Rooms
        {
            Id = room.Id,
            Name = room.Name,
            RoomType = room.RoomType,
            PricePerHour = room.PricePerHour,
            Status = room.Status
        }).ToList();
        return View(roomModels);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Rooms room)
    {
        if (ModelState.IsValid)
        {
            var roomDto = new Rooms
            {
                Name = room.Name,
                RoomType = room.RoomType,
                PricePerHour = room.PricePerHour,
                Status = room.Status
            };
            Room newRoom = new Room()
            {
                Name = roomDto.Name,
                RoomType = roomDto.RoomType,
                PricePerHour = roomDto.PricePerHour,
                Status = roomDto.Status
            };
            await _roomService.AddRoomAsync(newRoom);
            return RedirectToAction("Index");
        }
        return View(room);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
