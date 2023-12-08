using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NDI.Api.Infrastructure.Migrations
{
    public partial class AddSeederQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("05872a5f-b316-461f-9f05-eb167aa08a08"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 1, 0, 0, 0)), null, "La pollution", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("2ea85c43-cc0d-43ca-821d-203a54f9ec43"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 1, 0, 0, 0)), null, "Le réchauffement climatique", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2571), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("7c8c0352-97b7-4243-ac0e-e70afeb7fe72"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 1, 0, 0, 0)), null, "La fonte des glaces", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("8c9c7a7b-a9bb-41ad-b89f-e521794711df"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 1, 0, 0, 0)), null, "Agriculture et alimentation : moins de viande, plus de pratiques durables", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("d59c1125-7cf9-47c1-8753-5d867980718f"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 1, 0, 0, 0)), null, "Transports : transformer les mobilités individuelles", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedAt", "Text", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2736), new TimeSpan(0, 1, 0, 0, 0)), "Quel est le secteur le plus émetteur de gaz à effet de serre en France ?", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("6863251d-2de3-4355-af12-18b95c144c20"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2748), new TimeSpan(0, 1, 0, 0, 0)), "Combien de tonnes de CO2 émet un vol Paris-New York par passager ?", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 1, 0, 0, 0)), "Quel est le secteur le plus émetteur de gaz à effet de serre dans le monde ?", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, 1, 0, 0, 0)), "Combien de tonnes de CO2 un citoyen devrait emettre selon le GIEC ?", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2755), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "CreatedAt", "LinkString", "LongDescription", "MemoryCardId", "ShortDescription", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4f1e2eeb-7f0b-4f51-b408-f417009df9c0"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéficesprotection de la biodiversité, meilleure qualité de l’eau, de l’air et des sols, sécurité alimentaire… L’agroforesterie, c’est-à-dire l’association d’arbres, de cultures et/ou de bétail sur une même parcelle, montre également un fort potentiel d’atténuation.\n\nLes forêts et écosystèmes absorbent du carbone, il est donc important de les protéger et de lutter contre la déforestation. Toutefois, cela ne pourra pas compenser la réduction des émissions, qui doit rester la priorité dans tous les secteurs.\n\nLe GIEC confirme par ailleurs que le passage à des régimes alimentaires riches en protéines végétales (légumes secs, céréales) et pauvres en viande et en produits laitiers permettent une forte réduction des émissions de GES.", new Guid("8c9c7a7b-a9bb-41ad-b89f-e521794711df"), "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("70dec4a0-2985-4648-99d6-54edd17b78d5"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours : la fonte des glaces et l'élévation du niveau des mers. La fonte des glaces est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("7c8c0352-97b7-4243-ac0e-e70afeb7fe72"), "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("861a6be0-cfec-4cc1-afd6-beebb32eef24"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "La pollution est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.", new Guid("05872a5f-b316-461f-9f05-eb167aa08a08"), "La pollution est un phénomène qui affecte la qualité de l'environnement", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("900064ba-56b1-4917-b993-9f61e54e6189"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/comprendre-urgence/", "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne de la surface terrestre.", new Guid("2ea85c43-cc0d-43ca-821d-203a54f9ec43"), "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("ef844d05-a4b4-46d7-9ff6-94675a63dfbd"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)), "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/", "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique. Parmi les actions identifiées par le GIEC dans tous les secteurs pour réduire les émissions de gaz à effet de serre en transformant les comportements individuels, celles qui concernent la mobilité sont celles qui présentent le plus grand potentiel de réduction de l’empreinte carbone. Les solutions citées par le rapport sont :\n\nDonner la priorité à une mobilité sans voiture, en privilégiant la marche et le vélo par exemple ;\n\nPrivilégier les transports en commun ;\n\nFavoriser les mobilités électriques ;\n\nRéduire les voyages en avion (surtout les vols longs courriers).\n\nÀ l’échelle des villes, une réorganisation des zones urbaines permettrait de réduire la consommation de carburant liée au transport urbain d’environ 25 %, notamment grâce à des infrastructures de transport moins dépendantes de la voiture et à un rapprochement entre le domicile et le lieu de vie.\nConcernant l’aviation, responsable à elle seule de 2,4% des émissions anthropiques de CO2, le GIEC rapporte qu’aucune amélioration en termes d’efficacité énergétique ne permettra de suivre le rythme de la croissance prévue du transport aérien. La limitation du trafic resterait donc le moyen le plus efficace pour réduire les émissions du secteur.\n\nUne action politique forte est indispensable pour effectuer ces transitions : il est nécessaire de proposer des aides et des options aux individus pour les accompagner dans ces changements d’habitudes de mobilité", new Guid("d59c1125-7cf9-47c1-8753-5d867980718f"), "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique.", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Reponses",
                columns: new[] { "Id", "CreatedAt", "IsCorrect", "QuestionId", "Text", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b564ac0-ab8c-4666-a464-bcb6f1c2b375"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2807), new TimeSpan(0, 1, 0, 0, 0)), true, new Guid("6863251d-2de3-4355-af12-18b95c144c20"), "3 tonnes", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("1ac603dc-cda8-479f-a720-4ba19ed3d949"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2781), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"), "Les transports", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("2ec61764-4c61-4edb-a4b5-f3f37cfde2ae"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("6863251d-2de3-4355-af12-18b95c144c20"), "1 tonne", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("34806e44-5f39-48de-9486-1313d237f966"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2759), new TimeSpan(0, 1, 0, 0, 0)), true, new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"), "Les transports", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("43b7e567-5cf2-4f81-af89-1b36fe00737e"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"), "1 tonne", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2818), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("810b4b39-3932-4234-9319-64904e63b294"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 1, 0, 0, 0)), true, new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"), "2 tonnes", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("8e31ebf5-8fe9-44f6-bd1e-fe9e2d3f4932"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2776), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"), "L'industrie", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2778), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("a405dbf2-0321-4e04-a501-61222acaf4c6"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"), "L'agriculture", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("e24a60b1-e7c8-4dad-bf5e-94b62a36cccd"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"), "L'agriculture", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2773), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("ec5d5a0f-b99f-4120-9772-1c4e9038d1bb"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2792), new TimeSpan(0, 1, 0, 0, 0)), true, new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"), "L'industrie", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("eed14d51-e9b5-40cc-b5a8-6430757a2bd5"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"), "3 tonnes", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 1, 0, 0, 0)) },
                    { new Guid("f881160f-f658-4ec3-a761-53dcc9152bd5"), new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 1, 0, 0, 0)), false, new Guid("6863251d-2de3-4355-af12-18b95c144c20"), "2 tonnes", new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 1, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("4f1e2eeb-7f0b-4f51-b408-f417009df9c0"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("70dec4a0-2985-4648-99d6-54edd17b78d5"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("861a6be0-cfec-4cc1-afd6-beebb32eef24"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("900064ba-56b1-4917-b993-9f61e54e6189"));

            migrationBuilder.DeleteData(
                table: "Informations",
                keyColumn: "Id",
                keyValue: new Guid("ef844d05-a4b4-46d7-9ff6-94675a63dfbd"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("0b564ac0-ab8c-4666-a464-bcb6f1c2b375"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("1ac603dc-cda8-479f-a720-4ba19ed3d949"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("2ec61764-4c61-4edb-a4b5-f3f37cfde2ae"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("34806e44-5f39-48de-9486-1313d237f966"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("43b7e567-5cf2-4f81-af89-1b36fe00737e"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("810b4b39-3932-4234-9319-64904e63b294"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("8e31ebf5-8fe9-44f6-bd1e-fe9e2d3f4932"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("a405dbf2-0321-4e04-a501-61222acaf4c6"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("e24a60b1-e7c8-4dad-bf5e-94b62a36cccd"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("ec5d5a0f-b99f-4120-9772-1c4e9038d1bb"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("eed14d51-e9b5-40cc-b5a8-6430757a2bd5"));

            migrationBuilder.DeleteData(
                table: "Reponses",
                keyColumn: "Id",
                keyValue: new Guid("f881160f-f658-4ec3-a761-53dcc9152bd5"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("05872a5f-b316-461f-9f05-eb167aa08a08"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("2ea85c43-cc0d-43ca-821d-203a54f9ec43"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("7c8c0352-97b7-4243-ac0e-e70afeb7fe72"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("8c9c7a7b-a9bb-41ad-b89f-e521794711df"));

            migrationBuilder.DeleteData(
                table: "MemoryCards",
                keyColumn: "Id",
                keyValue: new Guid("d59c1125-7cf9-47c1-8753-5d867980718f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6863251d-2de3-4355-af12-18b95c144c20"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"));

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
        }
    }
}
