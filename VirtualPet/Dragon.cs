using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Dragon
    {
        // add these 4 items at the beginning of all classes (1. fields, 2. Properties 3. Constructors 4. Methods)
        //STATES
        //fields (at least three)
        //fields (camelCase)
        private bool isHungry;
        private bool isThirsty;
        private bool isTired;
        private int restlessDragon;

        //Properties (at least three)
        //GET property accessor is used to return the property value.
        //SET property accessor is used to assign a new value. 

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }
        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }
        public bool IsTired
        {
            get { return this.isTired; }
            set { this.isTired = value; }
        }
        public int RestlessDragon
        {
            get { return this.restlessDragon; }
            set { this.restlessDragon = value; }
        }

        //BEHAVIORS
        //Constructors
        public Dragon()
        {

        }

        public Dragon(bool isHungry, bool isThirsty, bool isTired, int restlessDragon)
        {
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isTired = isTired;
            this.restlessDragon = RestlessDragon;
        }

        //methods (at least three)
        public string Feed()
        {
            if (isHungry)
            {
                isHungry = false;
                return "Your Hungarian Horntailed Dragon is not hungry yet";
            }
            else
            {
                return "Your Hungarian Horntailed Dragon is very hungry. You better feed her or else...";
            }

        }

        public string Watered()
        {
            if (IsThirsty)
            {
                isThirsty = false;
                return "Your Hungarian Horntailed Dragon is thirsty";
            }
            else
            {
                return "Your Hungarian Horntailed Dragon is not thirsty, please do not over water your Dragon. ";
            }
        }
        public string Sleep()
        {
            if (isTired)
            {
                isTired = false;
                return "Your Hungarian Horntailed Dragon is not tired";
            }
            else
            {
                return "Your Hungarian Horntailed Dragion is tired. Best to let her sleep.";
            }
        }
        public string Play()
        {
            if (restlessDragon >= 10) //100 = 100% restless
            {
                return "Your Dragon needs to play, it's super restless.";
            }
            else if (restlessDragon > 50)
            {
                return "Draco could use some play time, if not now, soon!";
            }
            else
            {
                return "Draco needs to play NOW!";
            }
        }
    }
}
