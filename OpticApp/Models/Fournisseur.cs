using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Fournisseur
    {
        public int ID { get; set; }
        public string nomFournisseur { get; set; }
        public ICollection<Article> articles { get; set; }
    }
}
