using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Predmet
    {
        [Key]
        [Required]
        [DisplayName("Identifikator")]
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z ]+")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Naziv predmeta smije imati između 3 i 50 karaktera!")]

        public string Naziv { get; set; }
         
        public double ECTS { get; set; }
        [NotMapped]
        public List<string> UpisaniStudenti { get; set; }
        public Predmet(int id, string naziv, double ects) {
            ID = id;
            Naziv = naziv; 
            ECTS = ects;
        }
        public Predmet()
        {
        }
    }
}
