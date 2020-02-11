using System;
using System.Collections.Generic;
using System.Text;

namespace MazeRunner.GameObjects
{
    class Actor
    {
        public Actor(short level)
        {

        }

        //Declariations

        //Variables

        //Number that represense the total strength 
        //of an actor
        short characterLevel = 1;

        //Number to determine the strength of an
        //attack from a physical weapon
        short attack;

        //Number to determine the Defense against
        //a physical attack
        short defense;

        //Number to determine the strenght of a
        //magical attack
        short power;

        //Number to determine the defense against
        //a magical attack
        short resistance;
        
        //Number representing the amount of punishment
        //an actor can sustain before falling in combat
        short health = 1;

        //Number repersenting the amount effort an actor
        //can exert in dungeon
        short energy = 1;

        //Number representing the amount of health an 
        //actor can recover in a period of time
        short healthRegen = 1;

        //Number representing the amount of energy an
        //actor can recover in a period of time
        short energyRegen = 1;


        //Methods

        public void damage(short hit)
        {
            this.health -= hit;
        }

        public void fatigue(short amount)
        {
            this.energy -= amount;
        }


        public void advanceTime()
        {
            this.health += healthRegen;
            this.energy += energyRegen;
        }




    }
}
