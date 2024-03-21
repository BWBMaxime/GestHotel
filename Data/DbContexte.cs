using Microsoft.EntityFrameworkCore;
using GestHotel.Models;

namespace GestHotel.Data
{
    public class HotelDbContext : DbContext // Assurez-vous que vous héritez de DbContext de Microsoft.EntityFrameworkCore
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<PersonnelMenage> PersonnelMenage { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
