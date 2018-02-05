using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Program
    {

        public static Dragon petDragon = new Dragon();

        private static void Main(string[] args)

        {
            //create interactive console window
            //prompt user to choose what to do with the Dragon
            //call methods on Dragon object to do what the user wants

            Console.WriteLine("You are going to meet your Hungarian Horntail Dragon named Draco!");
            Console.WriteLine("She is just over 12 feet tall. The cave is damp.");
            Console.WriteLine("Draco is quite mild mannered for a Hungarian Horntail.");
            Console.WriteLine("You are lucky, Hungarian Hortails are rare.");
            Console.WriteLine("As you may know, Dragons are very old and wise, treat her well and she'll outlive you.");
            Console.WriteLine("");
            Console.WriteLine("Press -ENTER- to enter the DigiCave at your own risk!");
            Console.ReadLine(); //gathers value of return
            Console.Clear(); // this clears the screen for the next writeline.


            int choice = 1;
            bool quit = true;

            while (quit) // start the questioning loop  
            {
                choice = Display(); //choice input will be placed in the Display method

                switch (choice)
                {

                    case 1: //play with draco
                        Console.WriteLine("You played with Draco and no one got hurt!");
                        petDragon.Play();
                        break;
                    case 2://feed draco
                        Console.WriteLine("You just fed Draco?");
                        petDragon.Feed(); // calls dracoHungry state
                        break;

                    case 3://Water Draco
                        Console.WriteLine("You gave Draco Water?");
                        petDragon.Water(); // calls dracoWater state
                        break;
                    case 4: //exit cave
                        Console.WriteLine("Press 4 to exit cave");
                        Console.ReadLine();
                        Console.WriteLine("Draco says 'bye Felicia'!, whips her tail around and goes back into her cave.");
                        quit = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, thats not a choice. Draco is very particular about what she does. ");
                        Console.WriteLine("Please enter 1, 2, 3, 4 or 5 ");
                        break;
                }  // this ends the choice switch       
            } //while //end while loop
        } //this one ends the main 

        private static int Display()
        {
            int input = 0;

            Console.WriteLine();
            Console.WriteLine();
            if (petDragon.DracoAge == 1)//if dragon is equal to 1
            {
                Console.WriteLine("Draco is 1 year old");
            } //end if stmt
            else
            {
                Console.WriteLine("Draco is {0} years old.", petDragon.DracoAge);
            } //end else stmt

            Console.WriteLine();
            Console.WriteLine("Draco is " + petDragon.DracoHungry + "% not Hungry");
            Console.WriteLine("Draco is " + petDragon.DracoWater + "% not Thirsty");
            Console.WriteLine("Draco is " + petDragon.DracoHappy + "% Happy");
            //Console.WriteLine("Draco is " + petDragon.DracoAge + " years old");

            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Play with Draco");
            Console.WriteLine("2. Feed Draco");
            Console.WriteLine("3. Give Draco water");
            Console.WriteLine("4. Exit the Cave");
            

            try 
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a valid selection");
                Console.WriteLine("Please enter either 1, 2, 3, or 4");
            }//end try

            //the tick (if i'm getting the idea right - will add a year to Draco for every action (1-4) 
            //tick Draco's age
            //create stmts that reflect user choices - if this return that stmt
            petDragon.dracoAge += 100;
            petDragon.dracoHungry -= 1;
            petDragon.dracoHappy += 0;
            petDragon.dracoWater -= 1;
            petDragon.energyLevel += 0;
           
            if (petDragon.energyLevel < 1)
            {
                Console.Clear();
                Console.WriteLine("Do not wake a sleeping dragon. If you do - it will be your death. ");
                return 0;
            }
            if (petDragon.dracoWater < 1) //water draco
            {
                Console.Clear();
                Console.WriteLine("It is a myth that dragons do not need water. She has died of thirst.");
                return 0;
            }

            if (petDragon.dracoHungry < 1) //draco is dead
            {
                Console.Clear();
                Console.WriteLine("It is a horrible tragedy to kill a dragon. She is now in Dragon heaven.");
                return 0;
            }//end if
            else if (petDragon.dracoHappy < 1)//draco is not happy - she leaves
            {
                Console.Clear();
                Console.WriteLine("Dragons are a rare beast that do not tolerate unhappiness. She has left the cave for a better one");
                return 0;
            }//end else if
            else
            {
                return input;
            }//end else stmt

            
            
        }//end Display method

    }//end class Program
}//end namespace 
