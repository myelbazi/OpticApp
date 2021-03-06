﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpticApp.Data;

namespace OpticApp.Migrations
{
    [DbContext(typeof(OpticAppContext))]
    [Migration("20201128162856_init_db")]
    partial class init_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OpticApp.Models.Article", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fournisseurID")
                        .HasColumnType("int");

                    b.Property<string>("libelleArticle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prixAchat")
                        .HasColumnType("int");

                    b.Property<int>("prixVenteHT")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<int>("typeArticleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("fournisseurID");

                    b.HasIndex("typeArticleID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("OpticApp.Models.ArticlePosition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ArticlePosition");
                });

            modelBuilder.Entity("OpticApp.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("OpticApp.Models.EtatVisite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("libelleEtatVisite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EtatVisite");
                });

            modelBuilder.Entity("OpticApp.Models.Fournisseur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomFournisseur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fournisseur");
                });

            modelBuilder.Entity("OpticApp.Models.Paiement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datePaiement")
                        .HasColumnType("datetime2");

                    b.Property<int>("montant")
                        .HasColumnType("int");

                    b.Property<string>("remarque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typePaiementID")
                        .HasColumnType("int");

                    b.Property<int>("visiteID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("typePaiementID");

                    b.HasIndex("visiteID");

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("OpticApp.Models.TypeArticle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("libelleTypeArticle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TypeArticle");
                });

            modelBuilder.Entity("OpticApp.Models.TypePaiement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("libelleTypePaiement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TypePaiement");
                });

            modelBuilder.Entity("OpticApp.Models.Vente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("articleID")
                        .HasColumnType("int");

                    b.Property<int>("articlePositionID")
                        .HasColumnType("int");

                    b.Property<int>("montant")
                        .HasColumnType("int");

                    b.Property<int>("visiteID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("articleID");

                    b.HasIndex("articlePositionID");

                    b.HasIndex("visiteID");

                    b.ToTable("Vente");
                });

            modelBuilder.Entity("OpticApp.Models.Visite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLivraison")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePrescription")
                        .HasColumnType("datetime2");

                    b.Property<string>("OD_IntermAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_IntermAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_IntermBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_IntermPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_IntermSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_Intermcylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_doct1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_doct2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_ecart1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_ecart2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_ht1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_ht2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loinAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loinAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loinBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loinPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loinSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_loincylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_presAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_presBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_presPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_presSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OD_prescylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_IntermAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_IntermAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_IntermBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_IntermPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_IntermSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_Intermcylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_doct1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_doct2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_ecart1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_ecart2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_ht1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_ht2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loinAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loinAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loinBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loinPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loinSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_loincylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_presAxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_presBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_presPrisme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_presSphere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OG_prescylindre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("attachements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("clientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_visite")
                        .HasColumnType("datetime2");

                    b.Property<int>("etatVisiteID")
                        .HasColumnType("int");

                    b.Property<string>("ophtalmo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarques")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reste")
                        .HasColumnType("int");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("clientID");

                    b.HasIndex("etatVisiteID");

                    b.ToTable("Visite");
                });

            modelBuilder.Entity("OpticApp.Models.Article", b =>
                {
                    b.HasOne("OpticApp.Models.Fournisseur", "fournisseur")
                        .WithMany("articles")
                        .HasForeignKey("fournisseurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticApp.Models.TypeArticle", "typeArticle")
                        .WithMany("articles")
                        .HasForeignKey("typeArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpticApp.Models.Paiement", b =>
                {
                    b.HasOne("OpticApp.Models.TypePaiement", "typePaiement")
                        .WithMany("paiements")
                        .HasForeignKey("typePaiementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticApp.Models.Visite", "visite")
                        .WithMany()
                        .HasForeignKey("visiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpticApp.Models.Vente", b =>
                {
                    b.HasOne("OpticApp.Models.Article", "article")
                        .WithMany("ventes")
                        .HasForeignKey("articleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticApp.Models.ArticlePosition", "articlePosition")
                        .WithMany("ventes")
                        .HasForeignKey("articlePositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticApp.Models.Visite", "visite")
                        .WithMany("ventes")
                        .HasForeignKey("visiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpticApp.Models.Visite", b =>
                {
                    b.HasOne("OpticApp.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpticApp.Models.EtatVisite", "etatVisite")
                        .WithMany("articles")
                        .HasForeignKey("etatVisiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
