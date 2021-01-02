using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class TypePaiement
    {
        public int ID { get; set; }
        public string libelleTypePaiement { get; set; }
        public ICollection<Paiement> paiements { get; set; }
    }
}
