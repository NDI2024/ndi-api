﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NDI.Api.Infrastructure.EfCore;

#nullable disable

namespace NDI.Api.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NDI.Api.Domain.Entities.Information", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LinkString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MemoryCardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("MemoryCardId");

                    b.ToTable("Informations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("900064ba-56b1-4917-b993-9f61e54e6189"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2602), new TimeSpan(0, 1, 0, 0, 0)),
                            LinkString = "https://reseauactionclimat.org/comprendre-urgence/",
                            LongDescription = "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne de la surface terrestre.",
                            MemoryCardId = new Guid("2ea85c43-cc0d-43ca-821d-203a54f9ec43"),
                            ShortDescription = "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("861a6be0-cfec-4cc1-afd6-beebb32eef24"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 1, 0, 0, 0)),
                            LinkString = "https://reseauactionclimat.org/comprendre-urgence/",
                            LongDescription = "La pollution est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.",
                            MemoryCardId = new Guid("05872a5f-b316-461f-9f05-eb167aa08a08"),
                            ShortDescription = "La pollution est un phénomène qui affecte la qualité de l'environnement",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("70dec4a0-2985-4648-99d6-54edd17b78d5"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2628), new TimeSpan(0, 1, 0, 0, 0)),
                            LinkString = "https://reseauactionclimat.org/comprendre-urgence/",
                            LongDescription = "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours : la fonte des glaces et l'élévation du niveau des mers. La fonte des glaces est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.",
                            MemoryCardId = new Guid("7c8c0352-97b7-4243-ac0e-e70afeb7fe72"),
                            ShortDescription = "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("ef844d05-a4b4-46d7-9ff6-94675a63dfbd"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)),
                            LinkString = "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/",
                            LongDescription = "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique. Parmi les actions identifiées par le GIEC dans tous les secteurs pour réduire les émissions de gaz à effet de serre en transformant les comportements individuels, celles qui concernent la mobilité sont celles qui présentent le plus grand potentiel de réduction de l’empreinte carbone. Les solutions citées par le rapport sont :\n\nDonner la priorité à une mobilité sans voiture, en privilégiant la marche et le vélo par exemple ;\n\nPrivilégier les transports en commun ;\n\nFavoriser les mobilités électriques ;\n\nRéduire les voyages en avion (surtout les vols longs courriers).\n\nÀ l’échelle des villes, une réorganisation des zones urbaines permettrait de réduire la consommation de carburant liée au transport urbain d’environ 25 %, notamment grâce à des infrastructures de transport moins dépendantes de la voiture et à un rapprochement entre le domicile et le lieu de vie.\nConcernant l’aviation, responsable à elle seule de 2,4% des émissions anthropiques de CO2, le GIEC rapporte qu’aucune amélioration en termes d’efficacité énergétique ne permettra de suivre le rythme de la croissance prévue du transport aérien. La limitation du trafic resterait donc le moyen le plus efficace pour réduire les émissions du secteur.\n\nUne action politique forte est indispensable pour effectuer ces transitions : il est nécessaire de proposer des aides et des options aux individus pour les accompagner dans ces changements d’habitudes de mobilité",
                            MemoryCardId = new Guid("d59c1125-7cf9-47c1-8753-5d867980718f"),
                            ShortDescription = "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique.",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("4f1e2eeb-7f0b-4f51-b408-f417009df9c0"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 1, 0, 0, 0)),
                            LinkString = "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/",
                            LongDescription = "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéficesprotection de la biodiversité, meilleure qualité de l’eau, de l’air et des sols, sécurité alimentaire… L’agroforesterie, c’est-à-dire l’association d’arbres, de cultures et/ou de bétail sur une même parcelle, montre également un fort potentiel d’atténuation.\n\nLes forêts et écosystèmes absorbent du carbone, il est donc important de les protéger et de lutter contre la déforestation. Toutefois, cela ne pourra pas compenser la réduction des émissions, qui doit rester la priorité dans tous les secteurs.\n\nLe GIEC confirme par ailleurs que le passage à des régimes alimentaires riches en protéines végétales (légumes secs, céréales) et pauvres en viande et en produits laitiers permettent une forte réduction des émissions de GES.",
                            MemoryCardId = new Guid("8c9c7a7b-a9bb-41ad-b89f-e521794711df"),
                            ShortDescription = "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 1, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.MemoryCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("MemoryCards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ea85c43-cc0d-43ca-821d-203a54f9ec43"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2533), new TimeSpan(0, 1, 0, 0, 0)),
                            Title = "Le réchauffement climatique",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2571), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("05872a5f-b316-461f-9f05-eb167aa08a08"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2579), new TimeSpan(0, 1, 0, 0, 0)),
                            Title = "La pollution",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7c8c0352-97b7-4243-ac0e-e70afeb7fe72"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2584), new TimeSpan(0, 1, 0, 0, 0)),
                            Title = "La fonte des glaces",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2586), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("d59c1125-7cf9-47c1-8753-5d867980718f"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 1, 0, 0, 0)),
                            Title = "Transports : transformer les mobilités individuelles",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("8c9c7a7b-a9bb-41ad-b89f-e521794711df"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 1, 0, 0, 0)),
                            Title = "Agriculture et alimentation : moins de viande, plus de pratiques durables",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 1, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2736), new TimeSpan(0, 1, 0, 0, 0)),
                            Text = "Quel est le secteur le plus émetteur de gaz à effet de serre en France ?",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 1, 0, 0, 0)),
                            Text = "Quel est le secteur le plus émetteur de gaz à effet de serre dans le monde ?",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("6863251d-2de3-4355-af12-18b95c144c20"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2748), new TimeSpan(0, 1, 0, 0, 0)),
                            Text = "Combien de tonnes de CO2 émet un vol Paris-New York par passager ?",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2750), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, 1, 0, 0, 0)),
                            Text = "Combien de tonnes de CO2 un citoyen devrait emettre selon le GIEC ?",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2755), new TimeSpan(0, 1, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Reponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid?>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Reponses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34806e44-5f39-48de-9486-1313d237f966"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2759), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = true,
                            QuestionId = new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"),
                            Text = "Les transports",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e24a60b1-e7c8-4dad-bf5e-94b62a36cccd"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"),
                            Text = "L'agriculture",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2773), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("8e31ebf5-8fe9-44f6-bd1e-fe9e2d3f4932"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2776), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("0fa0fea9-f296-4690-811e-de4263f9d6fd"),
                            Text = "L'industrie",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2778), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("1ac603dc-cda8-479f-a720-4ba19ed3d949"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2781), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"),
                            Text = "Les transports",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("a405dbf2-0321-4e04-a501-61222acaf4c6"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"),
                            Text = "L'agriculture",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("ec5d5a0f-b99f-4120-9772-1c4e9038d1bb"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2792), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = true,
                            QuestionId = new Guid("9b8e0f3f-3d56-4bc5-b71f-9a7c4ada7500"),
                            Text = "L'industrie",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("2ec61764-4c61-4edb-a4b5-f3f37cfde2ae"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("6863251d-2de3-4355-af12-18b95c144c20"),
                            Text = "1 tonne",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("f881160f-f658-4ec3-a761-53dcc9152bd5"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("6863251d-2de3-4355-af12-18b95c144c20"),
                            Text = "2 tonnes",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0b564ac0-ab8c-4666-a464-bcb6f1c2b375"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2807), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = true,
                            QuestionId = new Guid("6863251d-2de3-4355-af12-18b95c144c20"),
                            Text = "3 tonnes",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("43b7e567-5cf2-4f81-af89-1b36fe00737e"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"),
                            Text = "1 tonne",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2818), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("810b4b39-3932-4234-9319-64904e63b294"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = true,
                            QuestionId = new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"),
                            Text = "2 tonnes",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("eed14d51-e9b5-40cc-b5a8-6430757a2bd5"),
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2826), new TimeSpan(0, 1, 0, 0, 0)),
                            IsCorrect = false,
                            QuestionId = new Guid("c01d1f9e-5b3c-4d17-aeae-c74d39e7a5db"),
                            Text = "3 tonnes",
                            UpdatedAt = new DateTimeOffset(new DateTime(2023, 12, 8, 2, 9, 57, 547, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 1, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("NbError")
                        .HasColumnType("int");

                    b.Property<decimal?>("Points")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Time")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Information", b =>
                {
                    b.HasOne("NDI.Api.Domain.Entities.MemoryCard", null)
                        .WithMany("Informations")
                        .HasForeignKey("MemoryCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Reponse", b =>
                {
                    b.HasOne("NDI.Api.Domain.Entities.Question", "Question")
                        .WithMany("Reponses")
                        .HasForeignKey("QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Score", b =>
                {
                    b.HasOne("NDI.Api.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.MemoryCard", b =>
                {
                    b.Navigation("Informations");
                });

            modelBuilder.Entity("NDI.Api.Domain.Entities.Question", b =>
                {
                    b.Navigation("Reponses");
                });
#pragma warning restore 612, 618
        }
    }
}
