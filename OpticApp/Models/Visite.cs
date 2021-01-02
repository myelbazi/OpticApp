using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Models
{
    public class Visite
    {
        public int ID   { get; set; }
        [Display(Name = "Client")]
        public int clientID { get; set; }
        public Client client { get; set; }
        [Display(Name = "Ophtalmo")]
        public string ophtalmo { get; set; }
        [Display(Name = "Date visite")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date_visite { get; set; }
        [Display(Name = "Date livraison")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLivraison { get; set; }
        [Display(Name = "Date préscription")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DatePrescription { get; set; }
        public string OD_loinSphere { get; set; }
        public string OD_loincylindre { get; set; }
        public string OD_loinAxe { get; set; }
        public string OD_loinAdd { get; set; }
        public string OD_loinPrisme { get; set; }
        public string OD_loinBase { get; set; }
        public string OD_IntermSphere { get; set; }
        public string OD_Intermcylindre { get; set; }
        public string OD_IntermAxe { get; set; }
        public string OD_IntermAdd { get; set; }
        public string OD_IntermPrisme { get; set; }
        public string OD_IntermBase { get; set; }
        public string OD_presSphere { get; set; }
        public string OD_prescylindre { get; set; }
        public string OD_presAxe { get; set; }
        public string OD_presPrisme { get; set; }
        public string OD_presBase { get; set; }
        public string OD_ecart1 { get; set; }
        public string OD_ecart2 { get; set; }
        public string OD_ht1 { get; set; }
        public string OD_ht2 { get; set; }
        public string OD_doct1 { get; set; }
        public string OD_doct2 { get; set; }
        public string OG_loinSphere { get; set; }
        public string OG_loincylindre { get; set; }
        public string OG_loinAxe { get; set; }
        public string OG_loinAdd { get; set; }
        public string OG_loinPrisme { get; set; }
        public string OG_loinBase { get; set; }
        public string OG_IntermSphere { get; set; }
        public string OG_Intermcylindre { get; set; }
        public string OG_IntermAxe { get; set; }
        public string OG_IntermAdd { get; set; }
        public string OG_IntermPrisme { get; set; }
        public string OG_IntermBase { get; set; }
        public string OG_presSphere { get; set; }
        public string OG_prescylindre { get; set; }
        public string OG_presAxe { get; set; }
        public string OG_presPrisme { get; set; }
        public string OG_presBase { get; set; }
        public string OG_ecart1 { get; set; }
        public string OG_ecart2 { get; set; }
        public string OG_ht1 { get; set; }
        public string OG_ht2 { get; set; }
        public string OG_doct1 { get; set; }
        public string OG_doct2 { get; set; }
       
        public int total { get; set; }    // calculable
        public int reste { get; set; }    // calculable
        public string attachements { get; set; }
        public int etatVisiteID { get; set; }
        public EtatVisite etatVisite { get; set; }
        public string remarques { get; set; }

        public ICollection<Vente> ventes { get; set; }
    }
}
