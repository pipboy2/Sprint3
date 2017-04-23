﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Universe
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //
        private List<SpaceTimeLocation> _spaceTimeLocations;
        private List<GameObject> _gameObjects;



        public List<SpaceTimeLocation> SpaceTimeLocations
        {
            get { return _spaceTimeLocations; }
            set { _spaceTimeLocations = value; }
        }

        public List<GameObject> GameObjects 
        {
            get { return _gameObjects; }
            set { _gameObjects = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeUniverse();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeUniverse()
        {
            _spaceTimeLocations = UniverseObjects.SpaceTimeLocations;
            _gameObjects = UniverseObjects.gameObjects;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****
        
        public bool IsValidSpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<int> spaceTimeLocationIds = new List<int>();

            //
            // create a list of space-time location ids
            //
            foreach (SpaceTimeLocation stl in _spaceTimeLocations)
            {
                spaceTimeLocationIds.Add(stl.SpaceTimeLocationID);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (spaceTimeLocationIds.Contains(spaceTimeLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="spaceTimeLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int spaceTimeLocationId)
        {
            SpaceTimeLocation spaceTimeLocation = GetSpaceTimeLocationById(spaceTimeLocationId);
            if (spaceTimeLocation.Accessible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return the next available ID for a SpaceTimeLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxSpaceTimeLocationId()
        {
            int MaxId = 0;

            foreach (SpaceTimeLocation spaceTimeLocation in _spaceTimeLocations)
            {
                if (spaceTimeLocation.SpaceTimeLocationID > MaxId)
                {
                    MaxId = spaceTimeLocation.SpaceTimeLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a SpaceTimeLocation object using an Id
        /// </summary>
        /// <param name="Id">space-time location Id</param>
        /// <returns>requested space-time location</returns>
        public SpaceTimeLocation GetSpaceTimeLocationById(int Id)
        {
            SpaceTimeLocation spaceTimeLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (SpaceTimeLocation location in _spaceTimeLocations)
            {
                if (location.SpaceTimeLocationID == Id)
                {
                    spaceTimeLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (spaceTimeLocation == null)
            {
                string feedbackMessage = $"The Space-Time Location ID {Id} does not exist in the current Universe.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return spaceTimeLocation;
        }

        public bool IsValidGameObjectByLocationId(int gameObjectId, int currentSpaceTimeLocation)
        {
            List<int> gameObjectIds = new List<int>();

            //
            // create a list of game object ids in current space-time location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.SpaceTimeLocationID == currentSpaceTimeLocation)
                {
                    gameObjectIds.Add(gameObject.ID);
                }

            }

            //
            // determine if the game object id is a valid id and return the result
            //
            if (gameObjectIds.Contains(gameObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public GameObject GetGameObjectById(int Id)
        {
            GameObject gameObjectToReturn = null;

            //
            // run through the game object list and grab the correct one
            //

            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.ID == Id)
                {
                    gameObjectToReturn = gameObject;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and expection
            //
            if (gameObjectToReturn == null)
            {
                string feedbackMessage = $"The Game Object ID {Id} does not exist in the current Universe";
                throw new ArgumentException(feedbackMessage, Id.ToString());
            }

            return gameObjectToReturn;
        }

        public List<GameObject> GetGameObjectsBySpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<GameObject> gameObjects = new List<GameObject>();

            //
            // run through the game object list and grab all that are in the current space-tiime location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.SpaceTimeLocationID == spaceTimeLocationId)
                {
                    gameObjects.Add(gameObject);
                }

            }

            return gameObjects;
        }

        public bool IsValidTravelerObjectByLocationId(int travelerObjectId, int currentSpaceTimeLocation)
        {
            List<int> travelerObjectIds = new List<int>();

            //
            // create a list of traveler object ids in current space-time location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.SpaceTimeLocationID == currentSpaceTimeLocation && gameObject is TravelerObject)
                {
                    travelerObjectIds.Add(gameObject.ID);
                }

            }

            //
            // determine if the game object id is a valid id and return the result
            //
            if (travelerObjectIds.Contains(travelerObjectId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TravelerObject> GetTravelerObjectsBySpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<TravelerObject> travelerObjects = new List<TravelerObject>();

            //
            // run through the game object list and grab all that are in the current space-time location
            //
            foreach (GameObject gameObject in _gameObjects)
            {
                if (gameObject.SpaceTimeLocationID == spaceTimeLocationId && gameObject is TravelerObject)
                {
                    travelerObjects.Add(gameObject as TravelerObject);
                }
            }

            return travelerObjects;
        }

        #endregion
    }
}