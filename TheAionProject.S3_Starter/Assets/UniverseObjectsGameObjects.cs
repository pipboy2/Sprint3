using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public static partial class UniverseObjects
    {
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                ID = 1,
                Name = "Bag of Gold",
                SpaceTimeLocationID = 2,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
            },

            new TravelerObject
            {
                ID = 2,
                Name = "Ruby of Saron",
                SpaceTimeLocationID = 3,
                Description = "A bright red jewel, roughly the size of a robin's egg",
                Type = TravelerObjectType.Treasure,
                Value= 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                ID = 3,
                Name = "Rotogenic Medicine",
                SpaceTimeLocationID = 3,
                Description = "A wooden box containing a small vial filled with a blue liquid.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = false,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                ID = 4,
                Name = "Norlan Document ND-3075",
                SpaceTimeLocationID = 3,
                Description =
                    "Memo: Origin Errata" + "/n" +
                    "Universal Date: 378598" + "/n" +
                    "/n" +
                    "It appears a potential origin for the technology is based on Plenatia 5 in the Star Reach Galaxy.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                ID = 4,
                Name = "Xantoria Market pass",
                SpaceTimeLocationID = 4,
                Description =
                    "A ticket to be able to get into the Xantoria Market.",
                Type = TravelerObjectType.Information,
                Value = 100,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                ID = 8,
                Name = "Aion Tracker",
                SpaceTimeLocationID = 0,
                Description =
                    "Standard issue device worn around wrist that allows for tracking and messaging",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                ID = 9,
                Name = "RatPak 47",
                SpaceTimeLocationID = 0,
                Description =
                    "Standard issue ration package contain nutrients for 72 hours.",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },
        };

    }
}
