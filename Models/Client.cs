namespace GestHotel.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string NumeroCarteBleue { get; set; } // Vous pouvez choisir de le stocker ou non dans la base de données

        // Constructeur par défaut requis pour Entity Framework Core
        public Client()
        {
        }

        // Constructeur avec paramètres
        public Client(string nom, string email, string numeroCarteBleue)
        {
            Nom = nom;
            Email = email;
            NumeroCarteBleue = numeroCarteBleue;
        }
    }

}
