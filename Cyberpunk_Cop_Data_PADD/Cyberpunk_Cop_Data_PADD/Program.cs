using System;
using System.Threading;

namespace Cyberpunk_Cop_Data_PADD
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dev Notes
             *---------------------------------------------------------
             * This is a console app for a cyberpunk cop data PADD written in C#
             * It's basic functions are to:
             *   -Take user input in form of a random 9 digit alphanumeric code
             *   -Based on above 9 digit code, generate the following
             *       -Name
             *       -Age
             *       -Expanded Citizen Id
             *       -Date of Birth (custom date system)
             *       -Randomly generated finger and retinal prints
             *       -Wanted Status
             *       -List of crimes
             *       -Generate random ticket/fines
             *   -Display all the information above
             *   -Print out a ticket with all the above information
             *   -Prints a seperate ticket for tickets/fines
             *---------------------------------------------------------
             */


            //Begin Boot Sequence
            //---------------------------------------------------------

            Console.WriteLine("System Starting, Please Wait....."); // prints the boot loading message

            int rand = new Random();
            Thread.Sleep(rand.Next((500, 5000)));

            Console.WriteLine("Loading Memory...... 64kb");
            Console.WriteLine("Loading Memory...... 128kb");
            //add random sleep time here
            Console.WriteLine("Loading Memory...... 256kb");
            Console.WriteLine("Loading Memory...... 512kb");
            //add random sleep time here

            Console.WriteLine("Memory Loaded");
            Console.WriteLine("Booting OS, Please Wait.....");
            //add random sleep time here, 30s minimum
            Console.WriteLine("        /|");
            Console.WriteLine("       / |");
            Console.WriteLine("      /  |");
            Console.WriteLine("     /   |");
            Console.WriteLine("    /    |");
            Console.WriteLine("   /     |");
            Console.WriteLine("  /      |");
            Console.WriteLine(" /       |");
            Console.WriteLine("/________|");
            Console.WriteLine("TRIANGLE CORPS PRESENTS");
            Console.WriteLine("Right Angle OS");
            Console.WriteLine("v 0.01.23.453");
            //end of boot sequence
            //---------------------------------------------------------

            //begin usage

            Console.WriteLine("Please Enter User ID:");
            string userId = Console.ReadLine();
            Console.WriteLine("Please Enter Password:");
            string userPassword = Console.ReadLine();
            Console.WriteLine("Connecting to GlobaNet Services.....");
            //add random sleep time here
            Console.WriteLine("Credentials Accepted, Welcome User " + userId);










        }
    }
}
