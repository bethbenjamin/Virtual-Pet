using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create interactive console window
            //prompt user to choose what to do with the Dragon
            //call methods on Dragon object to do what the user wants

            int userChoice;

            Dragon userDragon = new Dragon();

            do // start the questioning loop  //do while loop runs all the code first //
            {
                Console.WriteLine("Your Hungarian Horntail Dragon (Draco) is waiting impatiently for you");
                Console.WriteLine("What would you like to do with Draco?");
                Console.WriteLine("To feed Draco, type 1");
                Console.WriteLine("To water Draco, type 2");
                Console.WriteLine("To see how sleepy Draco is, type 3");
                Console.WriteLine("To play with Draco, type 4");
                Console.WriteLine("To quit or leave Draco alone, type 5");

                userChoice = int.Parse(Console.ReadLine());
            }while (userChoice != 5);




             
        }
    }
}
