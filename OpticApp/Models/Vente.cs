using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Vente
    {
        public int ID { get; set; }
        public int visiteID { get; set; }
        public Visite visite { get; set; }
        public int articleID { get; set; }
        public Article article { get; set; }
        public int articlePositionID { get; set; }
        public ArticlePosition articlePosition { get; set; }

        public int montant { get; set; }
    }
   
}
