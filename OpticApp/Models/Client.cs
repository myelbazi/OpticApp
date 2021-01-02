using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateNaissance { get; set; }
        [Display(Name = "Téléphone")]
        public string tel { get; set; }
        public string profession { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string mail { get; set; }
        [Display(Name = "Titre")]
        public string sexe { get; set; }
        public string remarque { get; set; }
        [NotMapped]
        [Display(Name = "Nom client")]

        public string nomComplet
        {
            get
            {
                return nom + " " + prenom;
            }
        }
    }
}
