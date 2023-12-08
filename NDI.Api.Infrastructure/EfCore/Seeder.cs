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
                ImagePath = "https://cdn.discordapp.com/attachments/1171399362308472837/1182445891257372692/mem5.png?ex=6584b98d&is=6572448d&hm=78ba47f144d58e9499d1ed58cf2327c05dc998cfaf093c2cba57929d97197bee&"
            },
            new MemoryCard
            {
                Title = "La pollution",
                ImagePath = "https://cdn.discordapp.com/attachments/1171399362308472837/1182459799426830346/mem9.png?ex=6584c681&is=65725181&hm=47dc1148abd9866ed8bf6859aa8283eb3603ee7b4b01971748e6a36f46328a89&"
            },
            new MemoryCard
            {
                Title = "La fonte des glaces",
                ImagePath = "https://cdn.discordapp.com/attachments/1171399362308472837/1182443020088520806/mem2.png?ex=6584b6e0&is=657241e0&hm=9786abe775eb0c2f0b4f3eb672b21d9760f66d3b4e43c44f33a37288487417c0&"
            },
            new MemoryCard()
            {
                Title = "Transports : transformer les mobilités individuelles",
                ImagePath = "https://cdn.discordapp.com/attachments/1171399362308472837/1182443020386304000/mem3.png?ex=6584b6e0&is=657241e0&hm=baab7e037db4112ae37769ac230da07e9ba986f93fc1f0515b42d62a5407fddb&"
            },
            new MemoryCard()
            {
                Title = "Agriculture et alimentation : moins de viande, plus de pratiques durables",
                ImagePath = "https://media.discordapp.net/attachments/1171399362308472837/1182443020667334777/mem4.png?ex=6584b6e0&is=657241e0&hm=f874ff428faf0163e13e640a0d8b763592157bbda940be40291e40dd178aa0e5&=&format=webp&quality=lossless&width=480&height=480"
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
        
    }
}