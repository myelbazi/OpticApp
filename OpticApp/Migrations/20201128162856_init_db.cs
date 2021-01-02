using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpticApp.Migrations
{
    public partial class init_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticlePosition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePosition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    dateNaissance = table.Column<DateTime>(nullable: false),
                    tel = table.Column<string>(nullable: true),
                    profession = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true),
                    ville = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true),
                    sexe = table.Column<string>(nullable: true),
                    remarque = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EtatVisite",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelleEtatVisite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtatVisite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomFournisseur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeArticle",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelleTypeArticle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeArticle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypePaiement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelleTypePaiement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePaiement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Visite",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientID = table.Column<int>(nullable: false),
                    ophtalmo = table.Column<string>(nullable: true),
                    date_visite = table.Column<DateTime>(nullable: false),
                    DateLivraison = table.Column<DateTime>(nullable: false),
                    DatePrescription = table.Column<DateTime>(nullable: false),
                    OD_loinSphere = table.Column<string>(nullable: true),
                    OD_loincylindre = table.Column<string>(nullable: true),
                    OD_loinAxe = table.Column<string>(nullable: true),
                    OD_loinAdd = table.Column<string>(nullable: true),
                    OD_loinPrisme = table.Column<string>(nullable: true),
                    OD_loinBase = table.Column<string>(nullable: true),
                    OD_IntermSphere = table.Column<string>(nullable: true),
                    OD_Intermcylindre = table.Column<string>(nullable: true),
                    OD_IntermAxe = table.Column<string>(nullable: true),
                    OD_IntermAdd = table.Column<string>(nullable: true),
                    OD_IntermPrisme = table.Column<string>(nullable: true),
                    OD_IntermBase = table.Column<string>(nullable: true),
                    OD_presSphere = table.Column<string>(nullable: true),
                    OD_prescylindre = table.Column<string>(nullable: true),
                    OD_presAxe = table.Column<string>(nullable: true),
                    OD_presPrisme = table.Column<string>(nullable: true),
                    OD_presBase = table.Column<string>(nullable: true),
                    OD_ecart1 = table.Column<string>(nullable: true),
                    OD_ecart2 = table.Column<string>(nullable: true),
                    OD_ht1 = table.Column<string>(nullable: true),
                    OD_ht2 = table.Column<string>(nullable: true),
                    OD_doct1 = table.Column<string>(nullable: true),
                    OD_doct2 = table.Column<string>(nullable: true),
                    OG_loinSphere = table.Column<string>(nullable: true),
                    OG_loincylindre = table.Column<string>(nullable: true),
                    OG_loinAxe = table.Column<string>(nullable: true),
                    OG_loinAdd = table.Column<string>(nullable: true),
                    OG_loinPrisme = table.Column<string>(nullable: true),
                    OG_loinBase = table.Column<string>(nullable: true),
                    OG_IntermSphere = table.Column<string>(nullable: true),
                    OG_Intermcylindre = table.Column<string>(nullable: true),
                    OG_IntermAxe = table.Column<string>(nullable: true),
                    OG_IntermAdd = table.Column<string>(nullable: true),
                    OG_IntermPrisme = table.Column<string>(nullable: true),
                    OG_IntermBase = table.Column<string>(nullable: true),
                    OG_presSphere = table.Column<string>(nullable: true),
                    OG_prescylindre = table.Column<string>(nullable: true),
                    OG_presAxe = table.Column<string>(nullable: true),
                    OG_presPrisme = table.Column<string>(nullable: true),
                    OG_presBase = table.Column<string>(nullable: true),
                    OG_ecart1 = table.Column<string>(nullable: true),
                    OG_ecart2 = table.Column<string>(nullable: true),
                    OG_ht1 = table.Column<string>(nullable: true),
                    OG_ht2 = table.Column<string>(nullable: true),
                    OG_doct1 = table.Column<string>(nullable: true),
                    OG_doct2 = table.Column<string>(nullable: true),
                    total = table.Column<int>(nullable: false),
                    reste = table.Column<int>(nullable: false),
                    attachements = table.Column<string>(nullable: true),
                    etatVisiteID = table.Column<int>(nullable: false),
                    remarques = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visite", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visite_Client_clientID",
                        column: x => x.clientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visite_EtatVisite_etatVisiteID",
                        column: x => x.etatVisiteID,
                        principalTable: "EtatVisite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(nullable: true),
                    libelleArticle = table.Column<string>(nullable: true),
                    prixAchat = table.Column<int>(nullable: false),
                    prixVenteHT = table.Column<int>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    typeArticleID = table.Column<int>(nullable: false),
                    fournisseurID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Article_Fournisseur_fournisseurID",
                        column: x => x.fournisseurID,
                        principalTable: "Fournisseur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Article_TypeArticle_typeArticleID",
                        column: x => x.typeArticleID,
                        principalTable: "TypeArticle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paiement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visiteID = table.Column<int>(nullable: false),
                    datePaiement = table.Column<DateTime>(nullable: false),
                    typePaiementID = table.Column<int>(nullable: false),
                    montant = table.Column<int>(nullable: false),
                    remarque = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paiement_TypePaiement_typePaiementID",
                        column: x => x.typePaiementID,
                        principalTable: "TypePaiement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paiement_Visite_visiteID",
                        column: x => x.visiteID,
                        principalTable: "Visite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vente",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visiteID = table.Column<int>(nullable: false),
                    articleID = table.Column<int>(nullable: false),
                    articlePositionID = table.Column<int>(nullable: false),
                    montant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vente_Article_articleID",
                        column: x => x.articleID,
                        principalTable: "Article",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vente_ArticlePosition_articlePositionID",
                        column: x => x.articlePositionID,
                        principalTable: "ArticlePosition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vente_Visite_visiteID",
                        column: x => x.visiteID,
                        principalTable: "Visite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_fournisseurID",
                table: "Article",
                column: "fournisseurID");

            migrationBuilder.CreateIndex(
                name: "IX_Article_typeArticleID",
                table: "Article",
                column: "typeArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_typePaiementID",
                table: "Paiement",
                column: "typePaiementID");

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_visiteID",
                table: "Paiement",
                column: "visiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vente_articleID",
                table: "Vente",
                column: "articleID");

            migrationBuilder.CreateIndex(
                name: "IX_Vente_articlePositionID",
                table: "Vente",
                column: "articlePositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Vente_visiteID",
                table: "Vente",
                column: "visiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Visite_clientID",
                table: "Visite",
                column: "clientID");

            migrationBuilder.CreateIndex(
                name: "IX_Visite_etatVisiteID",
                table: "Visite",
                column: "etatVisiteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paiement");

            migrationBuilder.DropTable(
                name: "Vente");

            migrationBuilder.DropTable(
                name: "TypePaiement");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "ArticlePosition");

            migrationBuilder.DropTable(
                name: "Visite");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "TypeArticle");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "EtatVisite");
        }
    }
}
