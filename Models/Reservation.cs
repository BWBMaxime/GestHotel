using GestHotel.Models;
using System;

namespace GestHotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ChambreId { get; set; }
        public DateTime DateArrivee { get; set; }
        public DateTime DateDepart { get; set; }
        public int ClientId { get; set; }
        public bool EstPaye { get; set; }

        // Relation avec la chambre
        public Chambre Chambre { get; set; }

        // Relation avec le client
        public Client Client { get; set; }
    }
}
