using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.GameObjects
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



        //Methods
        //Determine chance a door is open with a high chance
        private bool isOpenHigh()
        {
            int doorOpen = random(0, 2);

            if (doorOpen == 0)
                return false;
            else
                return true;
        }

        private bool isOpenLow()
        {
            int doorOpen = random(0, 1);

            if (doorOpen == 0)
                return false;
            else
                return true;
        }


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



        //Random roller
        private int random(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }





        //Variables
        //Doors
        private bool north = false;
        private bool south = false;
        private bool east = false;
        private bool west = false;

        private bool isGenerated = false;

        public bool North { get => north; set => north = value; }
        public bool South { get => south; set => south = value; }
        public bool East { get => east; set => east = value; }
        public bool West { get => west; set => west = value; }
        public bool IsGenerated { get => isGenerated; set => isGenerated = value; }


        //Items in room
        //
        //
        //


        //Enemies in room
        //
        //
        //
    }
}
