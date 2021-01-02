using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string libelleArticle { get; set; }
        public int prixAchat { get; set; }
        public int prixVenteHT { get; set; }
        public int stock { get; set; }
        public int typeArticleID { get; set; }
        public TypeArticle typeArticle { get; set; }
        public int fournisseurID { get; set; }
        public Fournisseur fournisseur { get; set; }
        public ICollection<Vente> ventes { get; set; }

    }
}
