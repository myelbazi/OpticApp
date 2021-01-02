using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class TypeArticle  // verre Monture lentille
    {
        public int ID { get; set; }
        public string libelleTypeArticle { get; set; }

        public ICollection<Article> articles { get; set; }
    }
}
