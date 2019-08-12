using System;
using System.Threading;

namespace Cyberpunk_Cop_Data_PADD
{
    class Program
    {
        public int MakeRandomSleepTime(Ranodm ran, int range1, int range2)
        {
            var sleepTime = ran.Next(range1, range2);
            return sleepTime;
        }


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
             * 
             * To Do List
             * ---------------------------------------------------------
             *  -Make all sleep times random
             *  -Make loading database timer based off % that was RNG
             *  -add various indexes
             * 
             * ---------------------------------------------------------
             */
           


            //Begin Boot Sequence
            //---------------------------------------------------------

            Console.WriteLine("System Starting, Please Wait....."); // prints the boot loading message

            //add a global sleep timer here

            Random random = new Random();
            int sleepTimer = random.Next(500, 5000); //generates a .5s to 5s delay
            //Console.WriteLine(sleepTimer);
            Thread.Sleep(sleepTimer); //pauses the program for a random interval
            
            Console.WriteLine("Loading Memory...... 64kb");
            Console.WriteLine("Loading Memory...... 128kb");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading Memory...... 256kb");
            Console.WriteLine("Loading Memory...... 512kb");
            Thread.Sleep(sleepTimer);

            Console.WriteLine("Memory Loaded");
            Console.WriteLine("Booting OS, Please Wait.....");
            Thread.Sleep(10000);
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
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Credentials Accepted, Welcome User " + userId);

            Console.WriteLine("Loading Database, Please Wait.....");
            Thread.Sleep(sleepTimer);

            int loadingOne = random.Next(5, 15);
            int loadingTwo = random.Next(16, 25);
            int loadingThree = random.Next(26, 50);
            int loadingFour = random.Next(51, 75);
            int loadingFive = random.Next(76, 99);
            int loadingSix = 100;

            Console.WriteLine("Loading: " + loadingOne +"%");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading: " + loadingTwo + "%");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading: " + loadingThree+ "%");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading: " + loadingFour + "%");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading: " + loadingFive + "%");
            Thread.Sleep(sleepTimer);
            Console.WriteLine("Loading: " + loadingSix + "%");

            Console.WriteLine("Loading Ticketing and Informational Database (TID)");
            Thread.Sleep(sleepTimer);

            Console.WriteLine("TID Loaded");
            Console.WriteLine("User ID: " + userId);
            Console.Write("Enter 9 character alphanumeric ID Number: ");
            string citizenID = Console.ReadLine();
            Console.WriteLine("Citizen ID: " + citizenID);

            Console.WriteLine("Loading, Please Wait.....");
            Thread.Sleep(sleepTimer);

            Console.WriteLine("ID Found, Loading......");
            Thread.Sleep(sleepTimer);

            string citizenName = "Jefferey"; //placeholder for a variable that references an index of names
            string citizenSurname = "Colmbs"; //place holder for a variable that references an index of surnames
            string wantedStatus = "Not Wanted"; //placeholder for a variable that contains their wanted status
            string bountyAmount = "None Available";
            string misdemeanors = "1x Drunk in Public";
            string felonies = "None on record";

            Console.WriteLine("Citizen ID: " + citizenID.ToUpper());
            Console.WriteLine("Registered Name: " + citizenName.ToUpper() + " " + citizenSurname.ToUpper());
            Console.WriteLine("Wanted Status: " + wantedStatus.ToUpper());
            Console.WriteLine("Bounty: " + bountyAmount.ToUpper());
            Console.WriteLine("List of previous violations: ");
            Console.WriteLine("Misdemeanors: " + misdemeanors.ToUpper());
            Console.WriteLine("Felonies: " + felonies.ToUpper());
            Console.ReadLine();









        }
    }
}
