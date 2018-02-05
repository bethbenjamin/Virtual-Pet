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

        public int dracoAge = 100; //age of dragon
        public int dracoHungry = 100; //dragon hunger out of 100
        public int dracoHappy = 100; //dragon happiness out of 100
        public int energyLevel = 100; //potential for energy gain or loss with hunger
        public int dracoWater = 100; //dragon water level out of 100 / same idea as Hungry


        //Properties (at least three)
        //GET property accessor is used to return the property value.
        //SET property accessor is used to assign a new value. 

        public int DracoHungry
        {
            get { return this.dracoHungry; }
            set { this.dracoHungry = value; }
        }
        public int DracoAge
        {
            get { return this.dracoAge; }
            set { this.dracoAge = value; }
        }
        public int DracoHappy
        {
            get { return this.dracoHappy; }
            set { this.dracoHappy = value; }
        }
        
        public int EnergyLevel
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }

        public int DracoWater
        {
            get { return this.dracoWater; }
            set { this.dracoWater = value; }
        }
        //BEHAVIORS
        //Constructors
        public Dragon()
        {
            //default constructor - never put anything in this constructor
            //takes no parameters (nothing in the parentheses)
        }


        public Dragon(int dracoHungry, int dracoHappy , int dracoAge, int energyLevel, int dracoWater)
        {
            this.dracoHungry = dracoHungry;
            this.dracoHappy = dracoHappy; 
            this.dracoAge = dracoAge; 
            this.energyLevel = energyLevel;
            this.dracoWater = dracoWater;
           
        }


        //methods(at least three)
        public void Play() // if she plays she will get hungry, get thirsty and lose energy.
        {
            dracoHappy += 0;
            dracoHungry -= 6;
            energyLevel -= 10;
            dracoWater -= 5;
            
        }//this is the end of DracoPlay method

        public void Feed() //if she feeds she will get thirsty and gain energy
        {
            if (dracoHungry > 10) //basically saying if dracoHungry is less than 1 do this:
            {
                Console.WriteLine("Did you just feed her a whale?  She's full. She can't eat anymore.");
                
            }
            else if (dracoHungry > 50) //less than or equal to 60
            {
                Console.WriteLine("Draco seems to be quite hungry.  One or two Fwoopers will do.");
            }
            else if (dracoHungry > 90) //almost at the end
            {
                Console.WriteLine("She is weak, she must be fed. Quick, someone get her an elephant!");
            }
            else
            {
                Console.WriteLine("Hungarian Horntails are even more vicious when hungry? It's now or never. ");
            }
            dracoHungry += 6; //if she eats she will get thirsty, increase energy and make her happy
            dracoWater -= 5;
            energyLevel += 5;
            dracoHappy += 3;
        } //this is the end of the feed method

        public void Water() //this needs to  be in string 

        {
            if (dracoWater < 20) //basically saying if dracoWater is less than 9 do this:
            {
                Console.WriteLine("She's had her fill of water at the moment. Best to not give her anymore water.");
            }
            else if (dracoWater > 50) //half way 
            {
                Console.WriteLine("Draco seems thirsty. Fill the water dish and run!");
            }
            else if(dracoWater > 90)
            {
                Console.WriteLine("Draco is dying of dehydration. Give her water!");
            }
            else
            {
                Console.WriteLine("Hungarian Horntails are even more vicious when thirsty? It's now or never. ");
            }
            dracoWater += 3;//if draco drinks water she will 
            dracoHungry -= 1;
            energyLevel += 2;
            dracoHappy -= 3;
        } //this is the end of the Water method
        public void DracoEat()
        {
            dracoHungry += 2; //this - an incrememnt of 2 (which is less than 5 set)
            dracoWater -= 1; //adds water when eats
            energyLevel += 1;
            dracoHappy -= 1;
        }//this is the end of the DracoEat method

       
        
          
            
        
    
      
    }//this ends the public class Dragon
}//this ends the namespace
