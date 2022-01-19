using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetitie
{
    class Restaurant
    {
    }

    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Denumire prea lunga")]
        public string Nume { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Descriere prea lunga")]
        public string Prenume { get; set; }
        public DateTime DataIntrare { get; set; }
        public int Telefon { get; set; }
    }

    public class RestaurantDbContext : DbContext
    {
        public DbSet<Client> Clienti { get; set; }
    }
}
