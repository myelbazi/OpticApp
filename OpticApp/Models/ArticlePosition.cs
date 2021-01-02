using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class ArticlePosition
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public ICollection<Vente> ventes { get; set; }
    }
}
