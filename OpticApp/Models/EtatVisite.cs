using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class EtatVisite //validé / payé / partiellement payé / Annulée
    {
        public int ID { get; set; }
        public string libelleEtatVisite { get; set; }
        public ICollection<Visite> articles { get; set; }
    }
}
