using System;
using System.Threading;

namespace Cyberpunk_Cop_Data_PADD
{
    class Program
    {
        private const int lowerRange = 500;
        private const int middleRange = 5000;
        private const int upperRange = 10000;

        public static string citizenID = "";
        public static string userID = "";
        public static string userPassword = "";

        public static string citizenName = "Jefferey"; //placeholder for a variable that references an index of names
        public static string citizenSurname = "Colmbs"; //place holder for a variable that references an index of surnames
        public static string wantedStatus = "Not Wanted"; //placeholder for a variable that contains their wanted status
        public static string bountyAmount = "None Available"; //only if wanted
        public static string misdemeanors = "1x Drunk in Public"; //refers to an index with multiple crimes, collates them
        public static string felonies = "None on record"; //same as line above


        //array framework laid out for later
        //private string[] name = new string[2];
        //private string[] surname = new string[2];
        //private string[] midInitial = new string[2]
        //private string[] wanted = new string[3];
        //private string[] bounty = new string[2];
        //private string[] misdemeanors = new string[2];
        //private string[] felonies = new string[2];




        private static int RandomSleepTimer(int int1, int int2) //generates a random value between two ints
        {
            var rnd = new Random();

            int sleepTime = rnd.Next(int1, int2);

            return sleepTime;
        }

        public static void BootLoading()
        {
            Console.WriteLine("System Starting, Please Wait....."); // prints the boot loading message
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("Loading Memory...... 64gb");
            Console.WriteLine("Loading Memory...... 128gb");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine("Loading Memory...... 256gb");
            Console.WriteLine("Loading Memory...... 512gb");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine("Memory Loaded");
            Console.WriteLine("Loading Bios v 0.12.03.23");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("     Main Processor:              TAC R9990 @ 7.25 GHz");
            Console.WriteLine("     Mathematics Co-Processor:    UMK 42069");
            Console.WriteLine("     Display Adapter Type:        MDA (Video Bios Present)");
            Console.WriteLine("     Display Resolution:          720 x 350 @ 50Hz");
            Console.WriteLine("     Drives Connected             Drive 0: 1.44TB, TAC M.2 NVME SSD");
            Console.WriteLine("     Total Conventional RAM:      512gb");
            Console.WriteLine("     Found BIOS Extension ROM at F0080, initializing....");
            Console.WriteLine("Booting OS, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(lowerRange, upperRange));
            Console.WriteLine(" _______       _______________   ");
            Console.WriteLine("|__   __|     / _   __________|  ");
            Console.WriteLine("   | |       / / | |             ");
            Console.WriteLine("   | |      / /  | |             ");
            Console.WriteLine("   | |     / /   | |             ");
            Console.WriteLine("   | |    / /    | |             ");
            Console.WriteLine("   | |   / /_____| |             ");
            Console.WriteLine("   | |  /  ______  |             ");
            Console.WriteLine("   | | / /       | |__________   ");
            Console.WriteLine("   |_|/_/        |____________|  ");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("TRIANGLE CORPS PRESENTS");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("Right Angle OS");
            Thread.Sleep(RandomSleepTimer(lowerRange, middleRange));
            Console.WriteLine("v 0.01.23.453");
        }

        public static string UserID()
        {
            Console.WriteLine("Please Enter User ID:");
            string userID = Console.ReadLine();
            return (userID);
        }

        public static string UserPW()
        {
            Console.WriteLine("Please Enter Password:");
            string userPassword = Console.ReadLine();
            return (userPassword);
        }

        public static void TIDloading()
        {
            Console.WriteLine("Connecting to GlobaNet Services.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("Credentials Accepted, Welcome User " + userID); //there is a bug here, does not output userID to console
            Console.WriteLine("Loading Database, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("Loading Ticketing and Informational Database (TID)");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("TID Loaded");
        }

        public static string TIDinterface()
        {
            Console.WriteLine("User ID: " + userID);
            Console.Write("Enter 9 character alphanumeric ID Number: ");
            string citizenID = Console.ReadLine();
            Console.WriteLine("Citizen ID: " + citizenID);
            Console.WriteLine("Loading, Please Wait.....");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            Console.WriteLine("ID Found, Loading......");
            Thread.Sleep(RandomSleepTimer(middleRange, upperRange));
            return (citizenID);

        }

        public static void TIDresults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Citizen ID: " + citizenID); //bug here, does not output citizenID to console
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Registered Name: " + citizenName.ToUpper() + " " + citizenSurname.ToUpper());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wanted Status: " + wantedStatus.ToUpper());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bounty: " + bountyAmount.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List of previous violations: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Misdemeanors: " + misdemeanors.ToUpper());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Felonies: " + felonies.ToUpper());
            Console.ReadLine();
            return;
            
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
             *  -do colored text DONE
             * 
             * ---------------------------------------------------------
             */




            BootLoading();

            UserID();

            UserPW();

            TIDloading();

            TIDinterface();

            TIDresults();





        }
    }
}
