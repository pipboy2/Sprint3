using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum TravelerAction
    {
        None,
        MissionSetup,
        LookAround,
        LookAt,
        PickUp,
        PutDown,
        Inventory,
        //PickUpItem,
        //PickUpTreasure,
        //PutDownItem,
        //PutDownTreasure,
        Travel,
        TravelerInfo,
        TravelerInventory,
        TravelerTreasure,
        TravelerLocationsVisited,
        ListSpaceTimeLocations,
        ListItems,
        ListTreasures,
        ListGameObjects,
        AdminMenu,
        ReturnToMainMenu,
        Exit
    }
}
