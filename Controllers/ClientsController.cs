using GestHotel.Data; // Assurez-vous d'importer le bon namespace pour HotelDbContext
using GestHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly HotelDbContext _context; // Utilisez HotelDbContext ici

    public ClientsController(HotelDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetClients()
    {
        return await _context.Clients.ToListAsync();
    }
}
