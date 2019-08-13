using System;
using System.Threading;

namespace Cyberpunk_Cop_Data_PADD
{
    class Program
    {
        private const int lowerRange = 500;
        private const int middleRange = 5000;
        private const int upperRange = 10000;

        private static int RandomSleepTimer(int int1, int int2) //generates a random value between two ints
        {
            var rnd = new Random();

            int sleepTime = rnd.Next(int1, int2);

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
             *       -have the crimes be weighted towards wanted status and bounty
             *   -Display all the information above
             *   -Print out a ticket with all the above information
             *   -Prints a seperate ticket for tickets/fines
             *   -Stores the two above tickets in .txt files
             *---------------------------------------------------------
             * 
             * To Do List
             * ---------------------------------------------------------
             *  
             *  MUST DO:
             *  -Make all sleep times random DONE
             *  -add various indexes/arrays
             *  -add password masking
             *  
             *  
             *  WOULD LIKE:
             *  -Good ascii art
             *  -more flavor
             *  -do colored text
             * 
             * ---------------------------------------------------------
             */



            //Begin Boot Sequence
            //---------------------------------------------------------
            Console.WriteLine("System Starting, Please Wait....."); // prints the boot loading message
            Console.WriteLine("Loading Memory...... 64kb");
            Console.WriteLine("Loading Memory...... 128kb");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine("Loading Memory...... 256kb");
            Console.WriteLine("Loading Memory...... 512kb");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine("Memory Loaded");
            Console.WriteLine("Booting OS, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine(" ______          ");
            Console.WriteLine("|__||__|     //||");
            Console.WriteLine("   ||       // ||");
            Console.WriteLine("   ||      //  ||");
            Console.WriteLine("   ||     //   ||");
            Console.WriteLine("   ||    //    ||");
            Console.WriteLine("   ||   //_____||");
            Console.WriteLine("   ||  //______||");
            Console.WriteLine("   || //       ||");
            Console.WriteLine("   ||//        ||");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("TRIANGLE CORPS PRESENTS");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("Right Angle OS");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("v 0.01.23.453");
            //end of boot sequence
            //---------------------------------------------------------

            //begin usage
            //---------------------------------------------------------
            Console.WriteLine("Please Enter User ID:");
            string userId = Console.ReadLine();
            Console.WriteLine("Please Enter Password:");
            string userPassword = Console.ReadLine();
            Console.WriteLine("Connecting to GlobaNet Services.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("Credentials Accepted, Welcome User " + userId);
            Console.WriteLine("Loading Database, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("Loading Ticketing and Informational Database (TID)");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("TID Loaded");
            Console.WriteLine("User ID: " + userId);
            Console.Write("Enter 9 character alphanumeric ID Number: ");
            string citizenID = Console.ReadLine();
            Console.WriteLine("Citizen ID: " + citizenID);
            Console.WriteLine("Loading, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("ID Found, Loading......");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));

            string citizenName = "Jefferey"; //placeholder for a variable that references an index of names
            string citizenSurname = "Colmbs"; //place holder for a variable that references an index of surnames
            string wantedStatus = "Not Wanted"; //placeholder for a variable that contains their wanted status
            string bountyAmount = "None Available"; //only if wanted
            string misdemeanors = "1x Drunk in Public"; //refers to an index with multiple crimes, collates them
            string felonies = "None on record"; //same as line above

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
