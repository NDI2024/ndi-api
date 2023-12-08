using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NDI.Api.Infrastructure.Migrations
{
    public partial class AddQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("7830f4eb-428b-48fd-95a0-11869e85d8da"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("7c85dd0e-6dbc-4fb4-91b6-2e8e2cdcb590"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("834e4178-554e-4f8d-b209-e65af96a897c"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("86902afa-f426-48d5-b4c1-a82c750e1270"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("dd9a74c0-7737-4ed7-9d00-04a9760c8ccc"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("283ff76d-0e6c-4b11-9fb7-44a566e67e8a"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("57418d78-a860-469d-abd9-01237f6193cd"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("582bed60-40ef-4027-980f-7fe9367d6921"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("798fe6ff-a647-4691-94a6-bffe03370545"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("992393eb-2477-4801-bff8-20de38ec4d90"));

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reponses_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "MemoryCards",
                columns: new[] { "Id", "CreatedAt", "ImagePath", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("077d815e-495b-4dc4-a8ca-3cb338ae7aa7"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6598), new TimeSpan(0, 1, 0, 0, 0)), null, "Agriculture et alimentation : moins de viande, plus de pratiques durables", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6601), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("245eaa3f-b9b3-4e57-8840-91b1b2238dab"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6575), new TimeSpan(0, 1, 0, 0, 0)), null, "La pollution", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("43438042-3b35-4924-8d29-0b694dd56aad"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 1, 0, 0, 0)), null, "Le réchauffement climatique", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6561), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("68a00ec3-b2e7-4d89-a36b-50ebabdb697f"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, 1, 0, 0, 0)), null, "Transports : transformer les mobilités individuelles", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6593), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("efad711b-ecfd-4ce5-bfc7-11fd8cc59179"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 1, 0, 0, 0)), null, "La fonte des glaces", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "CreatedAt", "LinkString", "LongDescription", "MemoryCardId", "ShortDescription", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8965faaf-92f0-4fba-a0ca-d848b08fad2e"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéficesprotection de la biodiversité, meilleure qualité de l’eau, de l’air et des sols, sécurité alimentaire… L’agroforesterie, c’est-à-dire l’association d’arbres, de cultures et/ou de bétail sur une même parcelle, montre également un fort potentiel d’atténuation.\n\nLes forêts et écosystèmes absorbent du carbone, il est donc important de les protéger et de lutter contre la déforestation. Toutefois, cela ne pourra pas compenser la réduction des émissions, qui doit rester la priorité dans tous les secteurs.\n\nLe GIEC confirme par ailleurs que le passage à des régimes alimentaires riches en protéines végétales (légumes secs, céréales) et pauvres en viande et en produits laitiers permettent une forte réduction des émissions de GES.", new Guid("077d815e-495b-4dc4-a8ca-3cb338ae7aa7"), "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("92880770-1914-4560-8490-307a8157b2fa"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "La pollution est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("245eaa3f-b9b3-4e57-8840-91b1b2238dab"), "La pollution est un phénomène qui affecte la qualité de l'environnement", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6633), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("b4d97db0-9886-47bf-9d17-57a1622d0b2b"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne de la surface terrestre.", new Guid("43438042-3b35-4924-8d29-0b694dd56aad"), "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("cb687ae5-d21f-4f26-b2e5-3e84e4eeadc0"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours : la fonte des glaces et l'élévation du niveau des mers. La fonte des glaces est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("efad711b-ecfd-4ce5-bfc7-11fd8cc59179"), "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6660), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("d8c9790f-62b5-49a5-a820-056cd1947041"), new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique. Parmi les actions identifiées par le GIEC dans tous les secteurs pour réduire les émissions de gaz à effet de serre en transformant les comportements individuels, celles qui concernent la mobilité sont celles qui présentent le plus grand potentiel de réduction de l’empreinte carbone. Les solutions citées par le rapport sont :\n\nDonner la priorité à une mobilité sans voiture, en privilégiant la marche et le vélo par exemple ;\n\nPrivilégier les transports en commun ;\n\nFavoriser les mobilités électriques ;\n\nRéduire les voyages en avion (surtout les vols longs courriers).\n\nÀ l’échelle des villes, une réorganisation des zones urbaines permettrait de réduire la consommation de carburant liée au transport urbain d’environ 25 %, notamment grâce à des infrastructures de transport moins dépendantes de la voiture et à un rapprochement entre le domicile et le lieu de vie.\nConcernant l’aviation, responsable à elle seule de 2,4% des émissions anthropiques de CO2, le GIEC rapporte qu’aucune amélioration en termes d’efficacité énergétique ne permettra de suivre le rythme de la croissance prévue du transport aérien. La limitation du trafic resterait donc le moyen le plus efficace pour réduire les émissions du secteur.\n\nUne action politique forte est indispensable pour effectuer ces transitions : il est nécessaire de proposer des aides et des options aux individus pour les accompagner dans ces changements d’habitudes de mobilité", new Guid("68a00ec3-b2e7-4d89-a36b-50ebabdb697f"), "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique.", new DateTimeOffset(new DateTime(2023, 12, 8, 1, 5, 55, 387, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reponses_QuestionId",
                table: "Reponses",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reponses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("8965faaf-92f0-4fba-a0ca-d848b08fad2e"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("92880770-1914-4560-8490-307a8157b2fa"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("b4d97db0-9886-47bf-9d17-57a1622d0b2b"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("cb687ae5-d21f-4f26-b2e5-3e84e4eeadc0"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("d8c9790f-62b5-49a5-a820-056cd1947041"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("077d815e-495b-4dc4-a8ca-3cb338ae7aa7"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("245eaa3f-b9b3-4e57-8840-91b1b2238dab"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("43438042-3b35-4924-8d29-0b694dd56aad"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("68a00ec3-b2e7-4d89-a36b-50ebabdb697f"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("efad711b-ecfd-4ce5-bfc7-11fd8cc59179"));

            migrationBuilder.InsertData(
                table: "MemoryCards",
                columns: new[] { "Id", "CreatedAt", "ImagePath", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("283ff76d-0e6c-4b11-9fb7-44a566e67e8a"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 1, 0, 0, 0)), null, "La fonte des glaces", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("57418d78-a860-469d-abd9-01237f6193cd"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1794), new TimeSpan(0, 1, 0, 0, 0)), null, "Le réchauffement climatique", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("582bed60-40ef-4027-980f-7fe9367d6921"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1892), new TimeSpan(0, 1, 0, 0, 0)), null, "Transports : transformer les mobilités individuelles", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("798fe6ff-a647-4691-94a6-bffe03370545"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1899), new TimeSpan(0, 1, 0, 0, 0)), null, "Agriculture et alimentation : moins de viande, plus de pratiques durables", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1901), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("992393eb-2477-4801-bff8-20de38ec4d90"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, 1, 0, 0, 0)), null, "La pollution", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "CreatedAt", "LinkString", "LongDescription", "MemoryCardId", "ShortDescription", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7830f4eb-428b-48fd-95a0-11869e85d8da"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1966), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéficesprotection de la biodiversité, meilleure qualité de l’eau, de l’air et des sols, sécurité alimentaire… L’agroforesterie, c’est-à-dire l’association d’arbres, de cultures et/ou de bétail sur une même parcelle, montre également un fort potentiel d’atténuation.\n\nLes forêts et écosystèmes absorbent du carbone, il est donc important de les protéger et de lutter contre la déforestation. Toutefois, cela ne pourra pas compenser la réduction des émissions, qui doit rester la priorité dans tous les secteurs.\n\nLe GIEC confirme par ailleurs que le passage à des régimes alimentaires riches en protéines végétales (légumes secs, céréales) et pauvres en viande et en produits laitiers permettent une forte réduction des émissions de GES.", new Guid("798fe6ff-a647-4691-94a6-bffe03370545"), "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("7c85dd0e-6dbc-4fb4-91b6-2e8e2cdcb590"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1956), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique. Parmi les actions identifiées par le GIEC dans tous les secteurs pour réduire les émissions de gaz à effet de serre en transformant les comportements individuels, celles qui concernent la mobilité sont celles qui présentent le plus grand potentiel de réduction de l’empreinte carbone. Les solutions citées par le rapport sont :\n\nDonner la priorité à une mobilité sans voiture, en privilégiant la marche et le vélo par exemple ;\n\nPrivilégier les transports en commun ;\n\nFavoriser les mobilités électriques ;\n\nRéduire les voyages en avion (surtout les vols longs courriers).\n\nÀ l’échelle des villes, une réorganisation des zones urbaines permettrait de réduire la consommation de carburant liée au transport urbain d’environ 25 %, notamment grâce à des infrastructures de transport moins dépendantes de la voiture et à un rapprochement entre le domicile et le lieu de vie.\nConcernant l’aviation, responsable à elle seule de 2,4% des émissions anthropiques de CO2, le GIEC rapporte qu’aucune amélioration en termes d’efficacité énergétique ne permettra de suivre le rythme de la croissance prévue du transport aérien. La limitation du trafic resterait donc le moyen le plus efficace pour réduire les émissions du secteur.\n\nUne action politique forte est indispensable pour effectuer ces transitions : il est nécessaire de proposer des aides et des options aux individus pour les accompagner dans ces changements d’habitudes de mobilité", new Guid("582bed60-40ef-4027-980f-7fe9367d6921"), "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique.", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1959), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("834e4178-554e-4f8d-b209-e65af96a897c"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours : la fonte des glaces et l'élévation du niveau des mers. La fonte des glaces est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("283ff76d-0e6c-4b11-9fb7-44a566e67e8a"), "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("86902afa-f426-48d5-b4c1-a82c750e1270"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne de la surface terrestre.", new Guid("57418d78-a860-469d-abd9-01237f6193cd"), "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("dd9a74c0-7737-4ed7-9d00-04a9760c8ccc"), new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1938), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "La pollution est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("992393eb-2477-4801-bff8-20de38ec4d90"), "La pollution est un phénomène qui affecte la qualité de l'environnement", new DateTimeOffset(new DateTime(2023, 12, 8, 0, 26, 5, 872, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 1, 0, 0, 0)) }
                });
        }
    }
}
