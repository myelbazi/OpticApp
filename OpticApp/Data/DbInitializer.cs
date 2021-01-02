using OpticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(OpticAppContext context)
        {
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Client[]
          {
                 new Client { nom="nom1",prenom="prenom1" },
                 new Client { nom="nom2",prenom="prenom2" },
                 new Client { nom="nom3",prenom="prenom3" },
                 new Client { nom="nom4",prenom="prenom4"},
                 new Client { nom="nom5",prenom="prenom5"},
          };
            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }
            context.SaveChanges();

            var typePayements = new TypePaiement[]
          {
                 new TypePaiement { libelleTypePaiement="Espèce" },
                 new TypePaiement { libelleTypePaiement="TPE" },
                 new TypePaiement { libelleTypePaiement="Chèque" },
          };
            foreach (TypePaiement tp in typePayements)
            {
                context.TypePaiements.Add(tp);
            }
            context.SaveChanges();

            var typeArticles = new TypeArticle[]
      {
                 new TypeArticle {libelleTypeArticle="Verre"  },
                 new TypeArticle { libelleTypeArticle="Monture" },
                 new TypeArticle { libelleTypeArticle="Lentille" },
      };
            foreach (TypeArticle ta in typeArticles)
            {
                context.TypeArticles.Add(ta);
            }
            context.SaveChanges();

            var fournisseurs = new Fournisseur[]
{
                 new Fournisseur {nomFournisseur="Fournisseur1"  },
                 new Fournisseur { nomFournisseur="Fournisseur2" },
                 new Fournisseur { nomFournisseur="Fournisseur3" },
};
            foreach (Fournisseur f in fournisseurs)
            {
                context.Fournisseurs.Add(f);
            }
            context.SaveChanges();

            var articles = new Article[]
            {
                 new Article {code="Code1",fournisseurID=1,libelleArticle="Article1",prixAchat=100,prixVenteHT=150,typeArticleID=1,stock=10},
                 new Article {code="Code2",fournisseurID=2,libelleArticle="Article2",prixAchat=200,prixVenteHT=250,typeArticleID=1,stock=10 },
                 new Article { code="Code3",fournisseurID=3,libelleArticle="Article3",prixAchat=300,prixVenteHT=350,typeArticleID=2,stock=10 },
            };
            foreach (Article a in articles)
            {
                context.Articles.Add(a);
            }
            context.SaveChanges();

            var visites = new Visite[]
           {
                 new Visite {clientID=1,DateLivraison=DateTime.Now.AddDays(5),etatVisiteID=2},
           };
            foreach (Visite v in visites)
            {
                context.Visites.Add(v);
            }
            context.SaveChanges();

            var paiements = new Paiement[]
{
                 new Paiement {visiteID=1, typePaiementID=1,datePaiement=DateTime.Now ,montant=200 },
                 new Paiement {visiteID=1, typePaiementID=1,datePaiement=DateTime.Now ,montant=300 },
                 new Paiement {visiteID=1, typePaiementID=1,datePaiement=DateTime.Now ,montant=500 },
};
            foreach (Paiement p in paiements)
            {
                context.Paiements.Add(p);
            }
            context.SaveChanges();

            var articlePositions = new ArticlePosition[]
            {
                 new ArticlePosition {Libelle="Loin_verre_OG" },
                 new ArticlePosition {Libelle="Loin_verre_OD" },
                 new ArticlePosition {Libelle="Loin_monture" },
                 new ArticlePosition {Libelle="pres_verre_OG" },
                 new ArticlePosition {Libelle="pres_verre_OD" },
                 new ArticlePosition {Libelle="pres_monture" },
                 new ArticlePosition {Libelle="accessoire" },
            };
            foreach (ArticlePosition ap in articlePositions)
            {
                context.ArticlePositions.Add(ap);
            }
            context.SaveChanges();


            var ventes = new Vente[]
            {
                 new Vente {articleID=1,articlePositionID=1,visiteID=1,montant=500 },
                 new Vente {articleID=2,articlePositionID=2,visiteID=1,montant=800 },
                 new Vente {articleID=3,articlePositionID=3,visiteID=1,montant=1500 },
            };
            foreach (Vente v in ventes)
            {
                context.Ventes.Add(v);
            }
            context.SaveChanges();
        }

    }
}
