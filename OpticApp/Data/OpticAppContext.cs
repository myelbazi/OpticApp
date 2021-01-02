using Microsoft.EntityFrameworkCore;
using OpticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpticApp.Data
{
    public class OpticAppContext : DbContext
    {
        public OpticAppContext(DbContextOptions<OpticAppContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TypePaiement> TypePaiements { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<EtatVisite> EtatVisites { get; set; }
        public DbSet<Visite> Visites { get; set; }
        public DbSet<TypeArticle> TypeArticles { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Vente> Ventes { get; set; }
        public DbSet<ArticlePosition> ArticlePositions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<TypePaiement>().ToTable("TypePaiement");
            modelBuilder.Entity<Paiement>().ToTable("Paiement");
            modelBuilder.Entity<EtatVisite>().ToTable("EtatVisite");
            modelBuilder.Entity<Visite>().ToTable("Visite");
            modelBuilder.Entity<TypeArticle>().ToTable("TypeArticle");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<Fournisseur>().ToTable("Fournisseur");
            modelBuilder.Entity<ArticlePosition>().ToTable("ArticlePosition");
            modelBuilder.Entity<Vente>().ToTable("Vente");

        }
    }
}
