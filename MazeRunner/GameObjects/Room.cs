using System;
using System.Collections.Generic;
using System.Text;

namespace MazeRunner.GameObjects
{
    class Room
    {
        //Consructors

        //Basic
        public Room(string direction, int chance)
        {

            //Randomly set doors open
            openDoors(chance);



            //Open door that user entered from or open all doors
            switch (direction)
            {
                case "n":
                    this.North = true;
                    break;
                case "s":
                    this.South = true;
                    break;
                case "w":
                    this.West = true;
                    break;
                case "e":
                    this.East = true;
                    break;
                default:
                    this.North = true;
                    this.South = true;
                    this.East = true;
                    this.West = true;
                    break;
            }//End Open doors

            IsGenerated = false;

        }// End Basic


        //Declariations

        //Variables
        //Doors
        private bool north = false;
        private bool south = false;
        private bool east = false;
        private bool west = false;

        private bool isGenerated = false;





        //Items in room
        //
        //
        //


        //Enemies in room
        //
        //
        //


        //Methods

        //Gets and Sets
        public bool North { get => north; set => north = value; }
        public bool South { get => south; set => south = value; }
        public bool East { get => east; set => east = value; }
        public bool West { get => west; set => west = value; }
        public bool IsGenerated { get => isGenerated; set => isGenerated = value; }

        //Determine chance a door is open with a high chance
        private bool isOpenHigh()
        {
            int doorOpen = random(0, 2);

            if (doorOpen == 0)
                return false;
            else
                return true;
        }//End isOpenHigh

        private bool isOpenLow()
        {
            int doorOpen = random(0, 1);

            if (doorOpen == 0)
                return false;
            else
                return true;
        }//End isOpenLow


        /// <summary>
        /// Open Doors
        /// Called in Method "Generate Room"
        /// Uses Method Is Open; High and Low to determine if the doors
        /// should be open with different chances
        /// </summary>
        /// <param name="chance">
        /// Int passed with 0 as high chance, 1 as low chance
        /// and anything else as a way to prevent bad generatations</param>
        private void openDoors(int chance)
        {
            if (chance == 0)
            {
                this.North = isOpenHigh();
                this.South = isOpenHigh();
                this.West = isOpenHigh();
                this.East = isOpenHigh();
                IsGenerated = true;
            }

            else if (chance == 1)
            {
                this.North = isOpenLow();
                this.South = isOpenLow();
                this.West = isOpenLow();
                this.East = isOpenLow();
                IsGenerated = true;
            }

            else
                IsGenerated = false;


        }

        /// <summary>
        /// Generate Room
        /// Called by "Walker" Method from GameObjects.Floor to
        /// generate rooms in the maze.
        /// Walker with determine direction moved and the chance
        /// doors will be open
        /// </summary>
        /// <param name="direction">Walker will choose a direction 
        /// as a string depending on the direction moved. It will pass
        /// a cardinal direction as a lowercase first letter or pass "a"
        /// if it is the starting room</param>
        /// <param name="chance">Walker will pass the chance of high (0) on
        /// the "main path" of the maze. Chance will change to low (1) on the
        /// second pass through the maze to close up dead ends.</param>
        public void generateRoom(string direction, int chance)
        {
            //Randomly set doors open
            openDoors(chance);



            //Open door that user entered from or open all doors
            switch (direction)
            {
                case "n":
                    this.North = true;
                    break;
                case "s":
                    this.South = true;
                    break;
                case "w":
                    this.West = true;
                    break;
                case "e":
                    this.East = true;
                    break;
                default:
                    this.North = true;
                    this.South = true;
                    this.East = true;
                    this.West = true;
                    break;
            }//End Open doors
        }

            //



        /// <summary>
        /// Random Roller
        /// Simple psedonumber generator used to get an
        /// integer from a low to high number
        /// </summary>
        /// <param name="min">Lowest possible integer</param>
        /// <param name="max">Highest possible integer</param>
        /// <returns>One integer within the range specified</returns>
        private int random(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }





        
    }
}
