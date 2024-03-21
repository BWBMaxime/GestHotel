namespace GestHotel.Models
{
    public class Chambre
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Tarif { get; set; }
        public int Capacite { get; set; }
        public string Etat { get; set; }
        public bool EstANettoyer { get; set; }
        public int? PersonnelMenageId { get; set; } // Ajout de l'ID du personnel de ménage assigné à la chambre

        // Relation avec le personnel de ménage
        public PersonnelMenage PersonnelMenage { get; set; }
    }
}
