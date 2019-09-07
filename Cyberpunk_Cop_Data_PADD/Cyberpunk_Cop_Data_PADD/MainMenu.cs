using System;
using System.Threading;

namespace Cyberpunk_Cop_Data_PADD
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
*  
*---------------------------------------------------------
*
* To Do List
* ---------------------------------------------------------
*  
*  MUST DO:
*  -Make all sleep times random DONE
*  -add various indexes/arrays
*  -add password masking DONE
*  
*  
*  WOULD LIKE:
*  -Good ascii art
*  -more flavor
*  -do colored text DONE
*
* ---------------------------------------------------------
*/

    class MainMenu
    {
        private const int lowerRange = 500; // in miliseconds
        private const int middleRange = 5000;
        private const int upperRange = 10000;

        public string citizenID = "";
        public string userID = "";
        public string userPassword = "";

        public string citizenName = "Jefferey"; //placeholder for a variable that references an index of names
        public string citizenSurname = "Colmbs"; //place holder for a variable that references an index of surnames
        public string wantedStatus = "Not Wanted"; //placeholder for a variable that contains their wanted status
        public string bountyAmount = "None Available"; //only if wanted, based off of citizenID
        public string misdemeanors = "1x Drunk in Public"; //refers to an index with multiple crimes, collates them
        public string felonies = "None on record"; //same as line above

        

        public void Start()
        {
            
            BootLoading();

            UserID();

            UserPW();

            TIDloading();

            TIDinterface();

            TIDresults();
        }




        private int RandomNumberGen(int int1, int int2) //generates a random value between two ints
        {
            var rnd = new Random();

            int randomNum = rnd.Next(int1, int2);

            return randomNum;
        }

        public void BootLoading() // prints the boot loading message
        {
            Console.WriteLine("System Starting, Please Wait.....");
            Thread.Sleep(RandomNumberGen(lowerRange, middleRange));
            Console.WriteLine("Loading Memory...... 64gb");
            Console.WriteLine("Loading Memory...... 128gb");
            Thread.Sleep(RandomNumberGen(lowerRange, upperRange));
            Console.WriteLine("Loading Memory...... 256gb");
            Console.WriteLine("Loading Memory...... 512gb");
            Thread.Sleep(RandomNumberGen(lowerRange, upperRange));
            Console.WriteLine("Memory Loaded");
            Console.WriteLine("Loading Bios v 0.12.03.23");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            Console.WriteLine("     Main Processor:              TAC R9990 @ 7.25 GHz");
            Console.WriteLine("     Mathematics Co-Processor:    UMK 42069");
            Console.WriteLine("     Display Adapter Type:        MDA (Video Bios Present)");
            Console.WriteLine("     Display Resolution:          720 x 350 @ 50Hz");
            Console.WriteLine("     Drives Connected             Drive 0: 1.44TB, TAC M.2 NVME SSD");
            Console.WriteLine("     Total Conventional RAM:      512gb");
            Console.WriteLine("     Found BIOS Extension ROM at F0080, initializing....");
            Console.WriteLine("Booting OS, Please Wait.....");
            Thread.Sleep(RandomNumberGen(lowerRange, upperRange));
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
            Thread.Sleep(RandomNumberGen(lowerRange, middleRange));
            Console.WriteLine("TRIANGLE CORPS PRESENTS");
            Thread.Sleep(RandomNumberGen(lowerRange, middleRange));
            Console.WriteLine("Right Angle OS");
            Thread.Sleep(RandomNumberGen(lowerRange, middleRange));
            Console.WriteLine("v 0.01.23.453");
        }

        public void UserID() //asks for user input in form of userID, returns the string userID
        {
            Console.WriteLine("Please Enter User ID:");
            userID = Console.ReadLine();
        }

        public string UserPW() //asks for user input in for of userPassword
        {
            Console.WriteLine("Please Enter Password:");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                //Backspace should not work
                if (key.Key != ConsoleKey.Backspace)
                {
                    userPassword += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            //Stops receiving keys once enter is pressed
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();

            return (userPassword);
        }

        public void TIDloading()
        {
            Console.WriteLine("Connecting to GlobaNet Services.....");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            Console.WriteLine("Credentials Accepted, Welcome User " + userID); 
            Console.WriteLine("Loading Database, Please Wait.....");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            Console.WriteLine("Loading Ticketing and Informational Database (TID)");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            Console.WriteLine("TID Loaded");
        }

        public string TIDinterface()
        {
            Console.WriteLine("User ID: " + userID);
            Console.Write("Enter 9 character alphanumeric ID Number: ");
            citizenID = Console.ReadLine();
            Console.WriteLine("Citizen ID: " + citizenID);
            Console.WriteLine("Loading, Please Wait.....");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            Console.WriteLine("ID Found, Loading......");
            Thread.Sleep(RandomNumberGen(middleRange, upperRange));
            return (citizenID);

        }

        public void TIDresults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Citizen ID: " + citizenID);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Registered Name: " + firstNameClass.firstNames[RandomNumberGen(1, 50)].ToUpper() + " " + citizenSurname.ToUpper());
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
    }
}