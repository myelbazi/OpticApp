using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Paiement
    { 
        public int ID { get; set; }
        public int visiteID { get; set; }
        public Visite visite { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datePaiement { get; set; }
        public int typePaiementID { get; set; }
        public TypePaiement typePaiement { get; set; }
        public int montant { get; set; }
        public string remarque { get; set; }

    }
}

