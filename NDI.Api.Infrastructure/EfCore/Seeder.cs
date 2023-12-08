using Microsoft.EntityFrameworkCore;
using NDI.Api.Domain.Entities;

namespace NDI.Api.Infrastructure.EfCore;

public static class Seeder
{
    public static void SeedAsync(ModelBuilder modelBuilder)
    {
        List<MemoryCard> memoryCards = new List<MemoryCard>()
        {
            new MemoryCard
            {
                Title = "Le réchauffement climatique",
            },
            new MemoryCard
            {
                Title = "La pollution",
            },
            new MemoryCard
            {
                Title = "La fonte des glaces",
            },
            new MemoryCard()
            {
                Title = "Transports : transformer les mobilités individuelles",
            },
            new MemoryCard()
            {
                Title = "Agriculture et alimentation : moins de viande, plus de pratiques durables",
            }
        };
        
        List<Information> informations = new List<Information>()
        {
            new Information
            {
                ShortDescription = "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère",
                LongDescription = "Le réchauffement climatique est un phénomène d'augmentation de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne des océans et de l'atmosphère, à l'échelle mondiale, qui se manifeste par des changements de la variabilité du climat et par des augmentations de la température moyenne de la surface terrestre.",
                Link = new List<string?>(){ "https://reseauactionclimat.org/comprendre-urgence/" },
                MemoryCardId = memoryCards[0].Id
            },
            new Information
            {
                ShortDescription = "La pollution est un phénomène qui affecte la qualité de l'environnement",
                LongDescription = "La pollution est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.",
                Link = new List<string?>(){ "https://reseauactionclimat.org/comprendre-urgence/" },
                MemoryCardId = memoryCards[1].Id
            },
            new Information
            {
                ShortDescription = "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours",
                LongDescription = "Parallèlement à la hausse des températures, le GIEC met en avant deux autres indicateurs qui sont « dans le rouge » et qui attestent des changements climatiques en cours : la fonte des glaces et l'élévation du niveau des mers. La fonte des glaces est un phénomène qui affecte la qualité de l'environnement, qui est lié à l'activité humaine et qui a des conséquences plus ou moins graves sur la santé humaine, les écosystèmes et la biodiversité.",
                Link = new List<string?>(){ "https://reseauactionclimat.org/comprendre-urgence/" },
                MemoryCardId = memoryCards[2].Id
            },
            new Information
            {
                ShortDescription = "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique.",
                LongDescription = "Les transports représentent le premier secteur émetteur de gaz à effet de serre en France (31%) et sont responsables d’un quart des émissions mondiales : leur décarbonation est donc un enjeu majeur dans la lutte contre le changement climatique. Parmi les actions identifiées par le GIEC dans tous les secteurs pour réduire les émissions de gaz à effet de serre en transformant les comportements individuels, celles qui concernent la mobilité sont celles qui présentent le plus grand potentiel de réduction de l’empreinte carbone. " +
                                  "Les solutions citées par le rapport sont :\n\nDonner la priorité à une mobilité sans voiture, en privilégiant la marche et le vélo par exemple ;\n\nPrivilégier les transports en commun ;\n\nFavoriser les mobilités électriques ;\n\nRéduire les voyages en avion (surtout les vols longs courriers).\n\nÀ l’échelle des villes, une réorganisation des zones urbaines permettrait de réduire la consommation de carburant liée au transport urbain d’environ 25 %, notamment grâce à des infrastructures de transport moins dépendantes de la voiture et à un rapprochement entre le domicile et le lieu de vie.\n" +
                                  "Concernant l’aviation, responsable à elle seule de 2,4% des émissions anthropiques de CO2, le GIEC rapporte qu’aucune amélioration en termes d’efficacité énergétique ne permettra de suivre le rythme de la croissance prévue du transport aérien. La limitation du trafic resterait donc le moyen le plus efficace pour réduire les émissions du secteur.\n\nUne action politique forte est indispensable pour effectuer ces transitions : il est nécessaire de proposer des aides et des options aux individus pour les accompagner dans ces changements d’habitudes de mobilité",
                Link = new List<string?>(){ "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/" },
                MemoryCardId = memoryCards[3].Id
            },
            new Information
            {
                ShortDescription = "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices",
                LongDescription = "Le secteur de l’agriculture, des forêts et de la gestion des sols présente lui aussi de nombreuses options pour l’atténuation.\n\nLes pratiques agroécologiques (réduction de l’utilisation d’engrais de synthèse, diversification des cultures, meilleure gestion des déjections animales…) permettent de limiter les émissions de gaz à effet de serre, de mieux stocker le CO2 dans les sols et apportent de multiples autres bénéfices" +
                                  "protection de la biodiversité, meilleure qualité de l’eau, de l’air et des sols, sécurité alimentaire… L’agroforesterie, c’est-à-dire l’association d’arbres, de cultures et/ou de bétail sur une même parcelle, montre également un fort potentiel d’atténuation.\n\nLes forêts et écosystèmes absorbent du carbone, il est donc important de les protéger et de lutter contre la déforestation. Toutefois, cela ne pourra pas compenser la " +
                                  "réduction des émissions, qui doit rester la priorité dans tous les secteurs.\n\nLe GIEC confirme par ailleurs que le passage à des régimes alimentaires riches en protéines végétales (légumes secs, céréales) et pauvres en viande et en produits laitiers permettent une forte réduction des émissions de GES.",
                Link = new List<string?>(){ "https://reseauactionclimat.org/6e-rapport-du-giec-quelles-solutions-face-au-changement-climatique/" },
                MemoryCardId = memoryCards[4].Id
            }
            
        };
        
        modelBuilder.Entity<MemoryCard>().HasData(memoryCards);
        modelBuilder.Entity<Information>().HasData(informations);

        List<Question> questions = new List<Question>()
        {
            new Question
            {
                Text = "Quel est le secteur le plus émetteur de gaz à effet de serre en France ?",
            },
            new Question
            {
                Text = "Quel est le secteur le plus émetteur de gaz à effet de serre dans le monde ?",
            },
            new Question
            {
                Text = "Combien de tonnes de CO2 émet un vol Paris-New York par passager ?",
            },
            new Question
            {
                Text = "Combien de tonnes de CO2 un citoyen devrait emettre selon le GIEC ?",
            }
        };

        List<Reponse> reponses = new List<Reponse>()
        {
            new Reponse
            {
                QuestionId = questions[0].Id,
                Text = "Les transports",
                IsCorrect = true
            },
            new Reponse
            {
                QuestionId = questions[0].Id,
                Text = "L'agriculture",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[0].Id,
                Text = "L'industrie",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[1].Id,
                Text = "Les transports",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[1].Id,
                Text = "L'agriculture",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[1].Id,
                Text = "L'industrie",
                IsCorrect = true
            },
            new Reponse
            {
                QuestionId = questions[2].Id,
                Text = "1 tonne",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[2].Id,
                Text = "2 tonnes",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[2].Id,
                Text = "3 tonnes",
                IsCorrect = true
            },
            new Reponse
            {
                QuestionId = questions[3].Id,
                Text = "1 tonne",
                IsCorrect = false
            },
            new Reponse
            {
                QuestionId = questions[3].Id,
                Text = "2 tonnes",
                IsCorrect = true
            },
            new Reponse
            {
                QuestionId = questions[3].Id,
                Text = "3 tonnes",
                IsCorrect = false
            }
        };
        
        modelBuilder.Entity<Question>().HasData(questions);
        modelBuilder.Entity<Reponse>().HasData(reponses);

    }
}