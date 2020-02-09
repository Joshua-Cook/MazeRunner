using System;
using System.Collections.Generic;
using System.Text;



namespace FirstApp.GameObjects
{
    class Floor
    {
        //Constructor
        //
        //
        //

        //Declariations

        //Methods
        private void createFloor()
        {
            
             
        }

        private void walker()
        {
            //Define Room Entry and chance of new doors
            string direction = "a";
            int chance = 0;
            currentRoom = floor[yCoord, xCoord];


            //Generate Room where the Walker is
            if (currentRoom.IsGenerated == false)
                currentRoom.generateRoom(direction, chance);


            //Check for Open Doors in adjacnet rooms
            if (currentRoom.North == true)
            {
                

                if (floor[yCoord - 1, xCoord].IsGenerated == true)
                {
                    if (floor[yCoord - 1, xCoord].South == false)
                        currentRoom.North = false;
                }

                else
                    filler.Add((yCoord - 1).ToString() + xCoord.ToString());
            }
            if (currentRoom.South == true)
            {
                if (floor[yCoord + 1, xCoord].IsGenerated == true)
                {
                    if (floor[yCoord + 1, xCoord].North == false)
                        currentRoom.South = false;
                }

                else
                    filler.Add((yCoord + 1).ToString() + xCoord.ToString());
            }
            if (currentRoom.East == true)
            {
                if (floor[yCoord, xCoord + 1].IsGenerated == true)
                {
                    if (floor[yCoord, xCoord + 1].West == false)
                        currentRoom.East = false;
                }

                else
                    filler.Add(yCoord.ToString() + (xCoord + 1).ToString());
            }
            if (currentRoom.West == true)
            {
                if (floor[yCoord, xCoord - 1].IsGenerated == false)
                    filler.Add(yCoord.ToString() + (xCoord- 1).ToString());
            }
        }

        //Variables
        GameObjects.Room[,] floor = new Room[10, 10];

        GameObjects.Room currentRoom = new Room("a", 0);


        int xCoord = 5;
        int yCoord = 5;

        List<string> filler = new List<string>();





    }
}
