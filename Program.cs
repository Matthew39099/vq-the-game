﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    public struct enemy
    {
        public string name;
        public int enemyHealth;
    }
    internal class Program
    {
        public static double EnemyHealth = 20, Health = 100, Damage, filament = 49, energy = 100;
        public static double armour = 0.1;
        public static double weapon = 0.5;
        public static double xp = 0;
        public static int pen = 0; 
        public static int roomid;
        public static double difficulty = 0.1;
        public static string EnemyName;
        public static double DamageMod = 1;
        public static int card = 0;
        public static int hallwayid = 0;
        //Room Visit ids
        public static int officeid = 0, hallwayintro = 0, closetid = 0, boom1id = 0, broom2id = 0;  //first floor 
        public static int printerid = 0, studioid = 0, mathsid = 0; //second floor



        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                        LOADING..                                                 \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  ");
                Thread.Sleep(700);
                Console.Clear();
                Console.WriteLine("                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                        LOADING...                                                \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  ");
                Thread.Sleep(700);
                Console.Clear();
                Console.WriteLine("                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                        LOADING....                                               \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  ");
                Thread.Sleep(700);
                Console.Clear();
                Console.WriteLine("                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                        LOADING......                                             \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  \r\n                                                                                                                  ");
                Thread.Sleep(700);
                Console.Clear();
            }
            Console.WriteLine("                                                                                       \r\n           @@@@@@@+=@@@@@@@#===+++%@@@@#-.                                             \r\n           :.-%###%@@@%=#@@@@@@@@@@==*@@@@                                     \r\n           +++%##=.=-+#%@#++-..:.:-+@@%-#@@@@                                  \r\n           .:++-=-:-+=-:-::----+###+=--*#:%@@@@@@@*..                                  \r\n           ::=-+@@@@@*:--::.-=+%@@@@@@@@@@@:@@@@@@@..                                  \r\n           @@@@%#@@@@@*@@@@@@@@@@@@@@@@@@@@@@#-=@@@+..                                 \r\n           @@@#@@@:=@@@@@@@@@@@@@@**+=-.+@@@@@@@@@@@@*.                                \r\n           +=%@%@@@@@@@@++%####*+++:=@@@@@@@    @@@*@@@:.                              \r\n           :+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@@*@@%=.                             \r\n           :::=+*+-...:#@@@@@@@@@@@@@@@+:.........=@@*@@@-.                            \r\n                        .....:::.........   ..... .*@@=#@@=......                      \r\n                                              .=@@@@%*#.*@@@##%@@@@%-.                 \r\n                                              .#@*+*+===:+@@+::--=#@#.                 \r\n                                              :@@%%@@@@@@+*@@@@@@@@@@-                 \r\n                                              -@@@@#--*#@@@%=::@@@@@@#..               \r\n                                             .-@@%@@@@@@@@@@@@@@@@+@@@..               \r\n                                             .=@@+@#*+-:.....:*@@@+@@@..               \r\n                                             .+@@+@%+=-:.....:*@@@=@@@.                \r\n                                             .=@@=@%*==-:.....+@@@=@@@..               \r\n                                             .:@@+@@#+=-:::.::*@@@=@@@..               \r\n                                             .:@@:@@*++-:::..:#@@@-@@@..               \r\n                                              :@@@@@**++=---==%@@@-@@+.                \r\n                                              .*@@#%@@@@@@@@@@@@@*@@@:.                \r\n                                              .-@@+=#@@@@@@@@@@@%*@@@.                 \r\n                                                         .%@@*#*+*-:-#+=:=-@@@-.                 \r\n                                                          =@@#*=*+%%*=**#@*@@@=.                 \r\n                     -                     .:-:::........ +@@@@@@@@@@@@@@@@@@@+.                 \r\n                     #                    .-###@@%++*##*+***@@@@@@@@@@@@@@@@@@=.                 \r\n                                                                                                 ");
            Thread.Sleep(2000);
            Menu();
        }
        /*starting bug fixing*/



        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("@@@@%@@%####%%%###################*####################################################%%########%%%@%@@@%%@@#####\r\n@%@%%@%###########*#########################**++=====+++***#####%%%%########################%%%%%#%%%%@@@%%%@#####\r\n@%%%####################################*+===+*****###%%%@%%%%%###%%@@@@%###################%%%%%#%%%%%@%%%%@####*\r\n%%%%##############**#################+++***##%%%%%%%%%%%@@@@@@@@@@@@@@%%%@@@%###############%%%%%###%%%@%%%%@%####\r\n%%%###############################***#*#%%%%%%%#%%%%%%%%%%@@@@@@@@@@@@@@@@@%@@@@#############%%%%####%%@%%%%@%####\r\n%%###########%%%#############%%#####%@%%%%%%%%%%%%%%%%*  +#@@%*  @@@@@@@@@@@@@%@@@%######%%#####%###%%%%%%%%@@####\r\n%%###########%%%%%##%##%%%%%@%%##%@@@%%%%%%+===+*###%%%  +%@@%+  @@@@+%@@@@@@@@@@@@@%%%%%####%%%%##%%%%%@%%%@@####\r\n%%#########%%##%%##%@@@@@@@%%##@@@@@%%%%%+        *#%%%  +%%%%+  @@@%@   @@@@@@@@@@@@@%%%###%%%%%%%%%%%%%%%%@@####\r\n%%#################%%%%%%@%#%@@@@@@@%%%%*  *###%   +%%%  +%%@%=  @@@@@@*     @@@@@@@@@@@%####%%%%%#%%%%%%%%%@@####\r\n%%%#%%############%%%%%@@#%@@@@@@#%%%%%%*  +#####   ###  +%%%%=  @@@@@#  @@@%@@@@@@@@@@@@@%%%#%%%%%%%%%%%%%%@@#%%%\r\n@%%%%%%%%%#%######%@@@@%#@@@@@@%=    %%%#   ##%##   ###+  %%%*  @@@@@%  @@@@@@@@@%@@@@@@@@@%%%%%%%%%%%%@@%%%@@%%%%\r\n@%%@@%%%%%%%%%%#%#%%@@%%@@@@@@%=   =  %%%#   *##+  *%%%%*      %@@@@@  %@@@@@@@@  *@@@@@@@@@%%%%%%%%%%%@@%%%@@%%%%\r\n@%@@@%%%%%%%%%%%%%%@@%@@@@@@@@@%=  +=   %%%#+     ###%%%%%%%%%%@@@@%  #@@@@@@@@  %@@@@@@@@@@@@%%%%%%%%%@@%%%@%%%%%\r\n@@%%@%%%%%%%%%%%%%@%%@@@@@%+*#%@%=  +==   #######%##%#%%%%%%%%%%@@@@%%%@@@@@@#  *@@@@  @@@@@@@@%%@@%%%%@@%%%@@%%%%\r\n@@%@@%%%%%%%%%%%%@%%@@@@@+#         +%=   #%%#########******##%%@@@@@@@@@@@@+  @   *  @@@@@@@@@@%@@@%%%@@%%%@%%%%%\r\n@@%@@%%%%%%%%%%%@%@@@@@@@@@   *==+  =+**#%######*++++++=====+++****%@@@@@@@%  @@@#=  @@@@@@@@@@@@@@@%%%@@%%%#+%%%%\r\n@@%@@%%%%%%%%%@@%@@@@@@@@@@@%   #%*==+%%%####+++===================***%@@@@@@@@@+=  @@@@@@@@@@@@@@@@@%%@@@@@#*%%%%\r\n@@@@@%%%%%%%%%@@%@@@@  @@@@@@@   ##%%%%#%#*++=========================**#@@@@@@%+  @@@@@@@@@@@@@@@%%%%@@@@@@@@%%%%\r\n@@@@@%%%%%%%%@@%@@@@#   @@@@@@%   #%%%%%*++====+*++*====================+*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@%%%%\r\n@@@@@@@%%%%%@@%@@@@@@@   @@@@@@%%%%%%%*++===**##++**==+++#++#=============*#%@@@@@@@@@@@%    @@@@@@@@@@@@@@@@@%%%%\r\n@@@@@@@%%%%%@%@@@@@@@@%   %%@@@%%%%%%++========                  ===========##@@@@@@@@#  %@@%  @@@@@@@@@@@@@@@%%%%\r\n@@@@@@@%@%%@@@@@@@            #%%%%#++========= START GAME    1  ============*#@@@@@@%  @@@@@@  @@@@@@@@@@@@@@%@@@\r\n@@@@@@@@@@@@%@@@@@@@@@@@@@%+*%@%%%#+===========                  =============+#%@@@@#  @@  @@  @@@@@@@@@@@@@@%@@@\r\n#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%#*============ HOW TO PLAY   2  ============+++#%@@@@#     @@@@@@@@@@@@@@@%%@@@@@\r\n*@@@@@@@@@@%@@@@@@@@@@@@@@@@@@%%#+=============                  ===============+#@@@@@%*@@@@@@@@@@@@@@@@@@#*@%%%%\r\n@@@@@@@@@@@@@@@@@@@@@@@@  #@@@%%*+============= CREDITS       3  ================*#@@@@@@@@@@@@@@@@@@@@@@@@**%%%%%\r\n@@@@@@@@@@%@@@@%@@@@@@@@   @@@@*+==============                  =================#%@@@@@@@@@@@@%@@@@@@@@@@+=%%%%%\r\n@@@@@@@@@@%@@@@      #%   @@@@#*=============== EXIT GAME     0  ================+*%@@@@@          @@@@@@@@#=%@@@@\r\n%@@@@@@@@@@@@@@           @@@@*================                  ==================#%@@@@#@@@@@@@@@@@@@@@@@@+%@@@@\r\n@%@@@@@@@@@@@@@@@@@@@@@@%@@@@%*=====*++*++++#=+==*===+=#=*==+=*=++=++%*=#+%%@%#%+++*%@@@@@@@@@@@@@@@@@@@@@@@#%@@@@\r\n@%@@@@@@@%@@@@@@@@@@@@@@@@@@@#+=======++=++++*===*====*#++==*==*==#%###%*#*========+%@@@@@@@@@@@@@@@@@@@@@@@%%@@@@\r\n@@@@@@@@@%@@@@     @@@@@@@@@@*+============*+*+==+====*#*+==*===**##++=*=*+%=======+#%@@@@        @@@@@@@@@@%@@@@@\r\n@@@@@@@@@%@@@@ @@@ @@@@@@@@@@*=============*#+**+++=++##+**+**+#**#@*+**++##*=====++*%@@@@@@@@%   @@@@@@@@@@%@@@@@\r\n@@@@@@@@@%@@@% @@@ @@@@@@@@@%*==============*******+**%****#%@#*#=+%##%%##%@======+++%@@@@@@*  @@@@@@@@@@@@@%@@@@@\r\n@@@@@@@@@%@@@%         *@@@@%*===============*#**#*+%#*##*+##%##%*%@##@*=+#=======+++%@@@@        @@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@%@@@@@@@@%#@@@@%*===============%%##%%#%++*%%#%@%%%%%%@%%#*+====++===++*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@%*+==============%@##%@@%%%%###@%#@@%#@@===+====++++==++*%@@@@@@@@@@@@@@@@@@@@@@@@%%@@\r\n@@@@@@@@@%@@@@@@@@@@@@@@@@@@@#+==============@%#%@@%%######%@@##*@%====+====++++++++#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            string temp;
            temp = Console.ReadLine();
            int input = Convert.ToInt32(temp);

            switch (input)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    Howtoplay();
                    break;
                case 3:
                    Credits();
                    break;
                case 0:
                    Exitgame();
                    break;
                default:
                    Console.WriteLine("Invalid input please choose between the numbers on the menu");
                    break;
            }
        }

        static void Howtoplay()
        {
            Console.Clear();
            Console.WriteLine(" __ __   ___   __    __      ______   ___       ____  _       ____  __ __ \r\n|  |  | /   \\ |  |__|  |    |      | /   \\     |    \\| |     /    ||  |  |\r\n|  |  ||     ||  |  |  |    |      ||     |    |  o  ) |    |  o  ||  |  |\r\n|  _  ||  O  ||  |  |  |    |_|  |_||  O  |    |   _/| |___ |     ||  ~  |\r\n|  |  ||     ||  `  '  |      |  |  |     |    |  |  |     ||  _  ||___, |\r\n|  |  ||     | \\      /       |  |  |     |    |  |  |     ||  |  ||     |\r\n|__|__| \\___/   \\_/\\_/        |__|   \\___/     |__|  |_____||__|__||____/ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Begin as the character Vaughn, find your gin by searching through various rooms.");
            Console.WriteLine("");
            Console.WriteLine("2. Each room you enter may contain an opponent you need to defeat before you can search the room.");
            Console.WriteLine("");
            Console.WriteLine("3. Choose your attack strength but be careful as your attacks consumes your energy depending on how intense your attacks are.");
            Console.WriteLine("");
            Console.WriteLine("4. Look for clues or items that may lead you to the gin.");
            Console.WriteLine("");
            Console.WriteLine("4. Successfully find the gin hidden in one of the rooms to win the game.");
            Console.WriteLine("");
            Console.WriteLine("Press enter to go back to the Main menu");
            Console.ReadLine();
            Menu();
        }

        static void Credits()
        {
            Console.Clear();
            string padding = new string(' ', 4);
            Console.WriteLine("    __  ____     ___  ___    ____  ______  _____     ______   ___  \r\n   /  ]|    \\   /  _]|   \\  |    ||      |/ ___/    |      | /   \\ \r\n  /  / |  D  ) /  [_ |    \\  |  | |      (   \\_     |      ||     |\r\n /  /  |    / |    _]|  D  | |  | |_|  |_|\\__  |    |_|  |_||  O  |\r\n/   \\_ |    \\ |   [_ |     | |  |   |  |  /  \\ |      |  |  |     |\r\n\\     ||  .  \\|     ||     | |  |   |  |  \\    |      |  |  |     |\r\n \\____||__|\\_||_____||_____||____|  |__|   \\___|      |__|   \\___/ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(new string('=', 20));  // Underline

            Console.WriteLine(padding + "Executive Producers");
            Console.WriteLine(padding + "====================");
            Console.WriteLine(padding + "Matthew Visser");
            Console.WriteLine();

            Console.WriteLine(padding + "Producers");
            Console.WriteLine(padding + "====================");
            Console.WriteLine(padding + "Caleb Chin");
            Console.WriteLine();

            Console.WriteLine(padding + "Programming");
            Console.WriteLine(padding + "====================");
            Console.WriteLine(padding + "Ricar Saaiman");
            Console.WriteLine();

            Console.WriteLine(padding + "Visuals");
            Console.WriteLine(padding + "====================");
            Console.WriteLine(padding + "Justine Mangubat");
            Console.WriteLine("");
            Console.WriteLine("Press enter to go back to the Main menu");
            Console.ReadLine();
            Menu();

        }
        static void Exitgame()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to exit? (y/n)");
            string temp = Console.ReadLine();

            if (temp == "y")
            {
                Environment.Exit(0);
            }
            else if (temp == "n")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'y' or 'n'.");
                Console.ReadLine();
            }
        }


        static void will()//method to add a enemy copy this when adding someone to the game
        {
            enemy will;
            will.name = "Office Lady";//sets enemy name
            will.enemyHealth = 25;// sets enemy health
            EnemyHealth = will.enemyHealth;// overides the last enemies health
            EnemyName = will.name;
            DamageMod = 1;
        }
        static void BussinessGuy()
        {
            enemy BussinessStudent;
            BussinessStudent.name = "Business Student";//sets enemy name
            BussinessStudent.enemyHealth = 20;// sets enemy health
            EnemyHealth = BussinessStudent.enemyHealth;// overides the last enemies health
            EnemyName = BussinessStudent.name;
            DamageMod = 1;
        }
        static void Krissi()
        {
            enemy Krissi;
            Krissi.name = "Krissi Wood";//sets enemy name
            Krissi.enemyHealth = 50;// sets enemy health
            EnemyHealth = Krissi.enemyHealth;// overides the last enemies health
            EnemyName = Krissi.name;
            DamageMod = 1.5;
        }
        static void farmBot()
        {
            enemy farmBot;
            farmBot.name = "Farm Bot";//sets enemy name
            farmBot.enemyHealth = 100;// sets enemy health
            EnemyHealth = farmBot.enemyHealth;// overides the last enemies health
            EnemyName = farmBot.name;
            DamageMod = 1.5;
        }
        static void printer()
        {
            enemy printer;
            printer.name = "3D Printer";//sets enemy name
            printer.enemyHealth = 30;// sets enemy health
            EnemyHealth = printer.enemyHealth;// overides the last enemies health
            EnemyName = printer.name;
            DamageMod = 1.25;
        }
        static void mathsStudent()
        {
            enemy mathStudent;
            mathStudent.name = "Deacon";//sets enemy name
            mathStudent.enemyHealth = 20;// sets enemy health
            EnemyHealth = mathStudent.enemyHealth;// overides the last enemies health
            EnemyName = mathStudent.name;
            DamageMod = 1.33;
        }
        static void Victor()
        {
            enemy Victor;
            Victor.name = "Victor";//sets enemy name
            Victor.enemyHealth = 75;// sets enemy health
            EnemyHealth = Victor.enemyHealth;// overides the last enemies health
            EnemyName = Victor.name;
            DamageMod = 1.6;
        }

        static void Equiptment()
        {

            if (weapon == 0.5)
            {
                Console.WriteLine("You have no weapon");
            }

            else if (weapon == 1)
            {
                Console.WriteLine("You have weapon 1");
            }

            else if (weapon == 1.5)
            {
                Console.WriteLine("You have weapon 2");
            }

            else if (weapon == 2)
            {
                Console.WriteLine("You have weapon 3 (Highest Level)");
            }


            if (armour == 0.1)
            {
                Console.WriteLine("You have no Armour");
            }

            else if (armour == 0.5)
            {
                Console.WriteLine("You have Vaughn boots, maybe you should go tramping");
                armour = 0.5;
            }

            else if (armour == 1)
            {
                Console.WriteLine("You have Ginmail");
                armour = 1;
            }

            else if (armour == 1.5)
            {
                Console.WriteLine("You have weapon ResinRanger Rain Coat ");
                armour = 1.5;
            }

            else if (armour == 2)
            {
                Console.WriteLine("You have PLA Power Vest (Highest Level)");
                armour = 2;
            }
        }
        static void callroom()
        {
            switch (hallwayid)
            {
                case 0:
                    hallway();
                    break;
                case 1:
                    hallway2();
                    break;
                case 2:
                    hallway3();
                    break;
            }
        }


        static void Start()
        {
            Console.Clear();
            Console.WriteLine("You wake up in a cold sweat, you are covered in first year math exams cover you. \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You thoughts are fuzzy but you remember two things.  \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You are the ALMIGHTY, POWERFUL, ROBUST, MEATY, STURDY, SOLID Vaughn Malkin and you need your Newplymouth Navy Gin! \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house.\nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You realize you are missing you favorite trusty bottle of Newplymouth Navy Gin \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Mission: Find your bottle of Newplymouth Navy Gin! \nSo you can go home and have a great weekend!");
            Console.WriteLine("Press enter to start"); 
            Console.ReadLine();
            roomid = 0;
            armour = 0;
            weapon = 0;
            office();
        }

        //admin/office - item room
        static void office()
        {
            if (officeid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }

            Console.Clear();
            roomid = 1;
            Console.WriteLine("You are in the Office \nPress Enter to Continue" );
            Console.ReadLine();
            Console.WriteLine("Your constant printing of rain forests paper for your math exams, has enraged the office lady  \n Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[OFFICE LADY]: VAUGHN! Your copious amounts of paper usage as greatly affected the environment have you no shame! \n Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Vaughn]: Rain forest shman forest, the children need these papers to do their exams. What are you the Lorax \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Your response angers the office lady \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Office Lady]: I AM THE LORAX AND I SPEAK FOR THE TREES, AND THE TREES SAY F U C K Y O U \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You see she morphs into THE LORAX \nPress Enter to continue ");
            Console.ReadLine();
            Console.WriteLine("You must now fight your way out of this one! \nPress Enter to continue");

            Console.ReadLine();
            officeid = 1; //prevents user from going back
            will(); //Will is known as the office lady
            fight(); //I believe this should be moved into the office yes you are correct i have moved it there now
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "office":
                    Console.WriteLine("Your are already here\n");
                    office();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        static void hallway()
        {
            string temp;
            int input;

            roomid = 2;
            Console.Clear();
            Console.WriteLine("You are in the Hallway");
            Thread.Sleep(1000);

            if (hallwayintro == 0)
            {

                Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? ");
                Thread.Sleep(1000);

                    Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground as there are better things to find (0)");
                    temp = Console.ReadLine();
                    input = Convert.ToInt32(temp);

                    if (input == 1)
                    {
                        Console.WriteLine("You have picked up the pen");
                        pen = 1;
                    }
                    else
                    {
                        pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                        Console.WriteLine("You choose not to pick up the pen it probably wasn't important");
                    }
                }
            

                Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground find? (0)");
                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);

                if (input == 1)
                {
                    Console.WriteLine("You have picked up the pen");
                    pen = 1;
                }
                else if (input == 0)
                {
                    pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                    Console.WriteLine("You choose not to pick up the pen it probably wasn't important");
                }
                else
                {
                    Console.WriteLine("Please select from the displayed options");
                }
            



            hallwayintro = 1;

            Console.WriteLine("You stand in the hallway, you can navigate to the (office), (broom1), (broom2), (closet)"); //Need to rename broom1 and broom2
            Console.WriteLine("Once you've explored all rooms on level 1, press ENTER");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here");
                    Thread.Sleep(3000);
                    Console.WriteLine("press ENTER to continue");
                    Console.ReadLine();
                    hallway();
                    break;
                case "office":
                    office();
                    break;
                case "broom1":
                    broom1();
                    break;
                case "broom2":
                    broom2();
                    break;
                case "closet":
                    closet();
                    break;
            }

            if (officeid == 1 && closetid == 1 && boom1id == 1 && broom2id== 1) //I feel like this should be a while loop and while not equal to this everything else runs for level 1?
            {
                Console.WriteLine("Congrats you have explored all of level 1");
                Thread.Sleep(3000);
                Console.WriteLine("The elevator is going up");
                Thread.Sleep(3000);
                hallwayid = 1;
                hallway2();
            }

        }

      

        //Janitor Closet 
        static void closet()
        {

            if (closetid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }


            Console.Clear();
            roomid = 3;
            Console.WriteLine("You are in Janitor Closet \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You enter a dark gloomy room, you see an ominous shadow lurking in the shadows \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You see Krissi emerge from the shadows \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Krissi]: Vaughn... I trust that you have brought me a pen?");
            Console.ReadLine();
            Console.WriteLine(" If you would like you see your boots again, I would a pen in return \nPress Enter to continue");
            Console.ReadLine();

            if (pen == 1)
            {
                Console.WriteLine("[Krissi]: Thank you for grabbing my pen, you know I am a true pen thief, thank you \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine("[Krissi]: Here are your special boots \nPress Enter to continue");
                Console.ReadLine();
                armour = 0.5;
                Thread.Sleep(1000);
                Console.WriteLine("[YOU EQUPIED YOUR BOOTS]");
            }

            else
            {
                Console.WriteLine("[Krissi]: Disappointing, you didn't bing me a pen how about you go else where"); //Change to Fight Code
                Krissi();
                fight();
            }

            closetid = 1;

            Console.WriteLine("You stand in the closet you can navigate to the (closet), (hallway)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "closet":
                    Console.WriteLine("You can't go back into a room you are already in! Try the hallway instead");
                    hallway();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        //Boss Room
        static void broom1()
        {
            string response;

            if (boom1id == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }



            //Angry Student Boss
            Console.Clear();
            roomid = 4;
            Console.WriteLine("[First Year Student]: Hi Vaughn, I was just wondering if you had marked my math exam? \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You can either respond with 'yes' or 'no'");
            response = Console.ReadLine();

            boom1id = 1;

            if (response == "yes" || response == "Yes")
            {
                Console.WriteLine("Yes, I'll get around to marking the math papers, I just have to find my gin");
            }
            else if (response == "no" || response == "NO");
            {
                Console.WriteLine("No!, I need to find my gin, I don't have time to mark math papers");
                BussinessGuy();// using his status
                fight();
            }

            Console.WriteLine("You stand in the broom1 you can navigate to the (broom1), (hallway)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom1":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom1();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        //Boss Room
        static void broom2()
        {
            string response;

            if (broom2id == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }



            //Business Student Boss
            Console.Clear();
            roomid = 5;
            broom2id = 1;
            Console.WriteLine("You enter into a into one of the business studies class rooms \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("The student comes over and begins trying to sell you crypto \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Do you wish to buy some crypto from the business studies student? \nPress Enter to continue");
            Console.ReadLine();
            Console.Write("Yes or No?");
            response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("[Business Studies Student]: Great I will sign you up - business studies student  \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine("[Business Studies Student]: Hey there! Want to skyrocket your bank account to the moon?  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: Well, hold onto your seatbelt because I've got something hotter than Elon's tweets: cryptocurrencies!  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: Picture this: you, sipping champagne on a yacht, courtesy of your crypto investments.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: Gone are the days of boring stocks and bonds. We're talking about digital gold, baby!  \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine("[Business Studies Student]: With crypto, you're not just an investor, you're a pioneer in the wild west of finance.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: And guess what? You don't need a fancy suit or a Wall Street address to get started.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: In the crypto world, everyone's welcome, from the hoodie-wearing tech geek to the hipster barista.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: So, what are you waiting for? Let's make those dreams of Lambos and private islands a reality!  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: Are you ready to dive into the crypto ocean with me?  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: Just imagine the thrill of riding the waves of Bitcoin highs and dodging the lows.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: It's like being a surfer on the biggest financial wave of the century!  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: And hey, even if you wipe out, there's always another wave waiting to lift you back up.  \nPress Enter to continue");
                Console.ReadLine(); 
                Console.WriteLine("[Business Studies Student]: So, grab your board and let's catch that crypto wave together!  \nPress Enter to continue");
            }
            else
            {
                Console.WriteLine("[Business Studies Student]: HOW DEAR YOU! YOU HAVEN'T EVEN LISTEND TO MY PITCH \nPress Enter to continue");
                Console.ReadLine();
                BussinessGuy();
                fight();
            }
            Console.WriteLine("You stand in the broom2 you can navigate to the (broom2), (hallway)");
            Console.WriteLine("You can now navigate to (broom2) or (hallway)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    //broom2();
                    Console.WriteLine("You can't go back into a room you are already in! Try the hallway instead");
                    hallway();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        
        //Second Floor

        static void hallway2()
        {
            Console.Clear();
            Console.WriteLine("You are now on the 2nd floor");
            Console.WriteLine("Once you've explored all rooms on level 2, you may need to press ENTER");
            Console.WriteLine("You stand in the second floor hallway you can navigate to the (printer), (studio), (maths)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "printer":
                    if (card == 1)
                    {
                        printerRoom();
                    }
                    else
                    {
                        Console.WriteLine("You need a card to unlock this room, You can get this by visting the maths room");
                        Thread.Sleep(3000);
                        hallway2();
                    }
                    break;
                case "studio":
                    studioRoom();
                    break;
                case "maths":
                    mathsRoom();
                    break;
            }

            if (printerid == 1 && studioid == 1 && mathsid == 1) //I feel like this should be a while loop and while not equal to this everything else runs for level 1?
            {
                Console.WriteLine("Congrats you have explored all of level 2");
                Thread.Sleep(3000);
                Console.WriteLine("The elevator is going up");
                Thread.Sleep(3000);
                hallwayid = 2;
                hallway3();
            }



        }
        static void mathsRoom()
        {

            if (mathsid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway2();
            }

            mathsid = 1;

            Console.WriteLine("You entered the Maths Room, Deacon is there, He does not look happy \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Deacon]: Vaughn you are making the tutorials a nightmare! \nPress Enter to continue ");
            Console.ReadLine();
            Console.WriteLine("None of the questions are easy! \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Deacon]: What is  eiπ + ln(−1) = x2 +∫0∞​xsin(x)​dx \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Deacon]: Wrong. I will have to tech you a lesson about maths");
            card = 1;
            mathsStudent();
            fight();
        }
        static void studioRoom()
        {

            if (studioid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway2();
            }


            studioid = 1;

            Console.WriteLine("Vic is here, he asks a serious question \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("[Vic]: How many seasons of The Simpsons are there?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 35)
            {
                Console.WriteLine("[Vic]: Wow I didn't expect you to guess that! Well done.");
                Console.WriteLine("Go explore the hallway");
                hallway2();
            }
            
            else
            {
                Console.WriteLine("[Vic]: How didn't you know that? Lets dance!");
                Victor();
                fight();
            }

        }


        static void printerRoom()
        {

            if (printerid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway2();
            }


            printerid = 1;

            //welcome to the room ect
            int choice;
            Console.WriteLine("There is only enough filament to print one thing");
            do
            {
                Console.WriteLine("1. To make a Weapon\n2. To make Armor");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    armour = 10;
                    Console.WriteLine("You got a Shield");
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    weapon = 10;
                    Console.WriteLine("You got a sword");
                }
            } while (choice != 1 && choice !=2);
            hallway2();
        }


        //Third Floor

        static void hallway3()
        {
            Console.WriteLine("You are now on the 3rd floor");
            Console.WriteLine("You stand in the third floor hallway you can navigate to the (hallway), (office)"); 
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    hallway3();
                    break;
                case "office":
                    VaughnOffice();
                    break;
            }

        }


        static void VaughnOffice()
        {
            Console.WriteLine("You entered Vaughn's office \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("It's dark and gloomy");
            Console.ReadLine();
            Console.WriteLine("A robot figure appears, It's Farm Bot! \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("He had returned to get his revenge \nPress Enter to continue");
            farmBot();
            fight();
            Console.WriteLine("You have defeated farmbot \nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You look around your office \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("you found your gin! \nPress Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Zoom Out");
            Console.WriteLine("                                                                                                                                                                                                                                                                                                      ");
            Console.WriteLine("                                                        :=+##@@@@@@@@@@@@@@#*=..                                                                                                                                                                                                                      ");
            Console.WriteLine("                                                  :+@@@%#=-                  =#%%@@*:.                                                                                                                                                                                                                ");
            Console.WriteLine("                                              =@@@#.                                =@@@*                                                                                                                                                                                                             ");
            Console.WriteLine("                                          -@@@=                                         -@@@=                                                                                                                                                                                                         ");
            Console.WriteLine("                                       +@@+.                                               .+@@+                                                                                                                                                                                                      ");
            Console.WriteLine("                                    :%@*      :                                                =@%=                                                                                                                                                                                                   ");
            Console.WriteLine("                                  +@%.                                                           .*@+                                                                                                                                                                                                 ");
            Console.WriteLine("                                %@*                                                                 +@@.                                                                                                                                                                                              ");
            Console.WriteLine("                              #@=                                                                     :@%                                                                                                                       :                                                                     ");
            Console.WriteLine("                            *@*                                                                         =@*                                                                                         ::=+*######***+********+***+*#++++===.                                                            ");
            Console.WriteLine("                          =@#                                                                             *@+                                                                                  .:=+**##################################%%#*:.                                                         ");
            Console.WriteLine("                        .%@.                                                                                #@.                                                                           .--+=*#*############%####%#%########%###%%##%###%###+=:                                                     ");
            Console.WriteLine("                       =@=                                                                                   -@+                                                                      .-=+*******###**#####%%%%%%##%%%%%#%#%%##%%%#%%#%*#%########*:.                                                 ");
            Console.WriteLine("                      @@                                                                                       %@                                                                   .=+#*#*#*########%%%%%#%#%%%%%%%%##%%########%#%%%%#%%##%########*-:                                              ");
            Console.WriteLine("                    .@#                                                                                         +@-                                                               .+*#*####*#######%#%%%%%%%%#%%%%%%%%%##%####%##%######%#%###%##*#*##**-                                             ");
            Console.WriteLine("                   =@+                                                                                           :@*                                                            -+####*###*#####%%%#*%%%%@%%%%%%###%%##%%%%%###%%#######%##############*#+.                                           ");
            Console.WriteLine("                  +@-                                                                                             .@+                                                        :+*****#####*######%%#*#%*%#%#####*##*####%###%%###########%##%%%%%##########*=:                                         ");
            Console.WriteLine("                 +@-          .                                                                                     @%                                                       -**+***#**#####%%#####*#%*###*####**#*#%%%%######%%###%%##%#*%%%%###%%###%#%#***:                                        ");
            Console.WriteLine("                #@       %*   @-                                            *@:                                      @%                                                    .+***#+*****#####%%%######%%######*################*#%##%######%##%%%%%%%#%#%%%##**+-                                      ");
            Console.WriteLine("               +@:       @#   @:                                                                                      %#                                                  :=+***#******####%%%%##**#%%%%###%##%#***###%#######%#######%%%##########%%%%%%%%%##**+:                                    ");
            Console.WriteLine("              +@:        @#   -   =@=%%@%:-%%@@:        #@#%@@@.  =@@%@@=   -@   *#=%%@@-   .%%#%@@@                  .@*                                               .+**#**=*++*#*#####%#%%%####%%%%##%%%%%%#*##*#####*%####%#%#%#%#%############%##%%#%###**==                                   ");
            Console.WriteLine("             :@+         @#       =@+   #@=   %%       %#   =@:  %@    :@+  -@   #@-   *@   %#   =@                    .@=                                             .-******+=++++*#####%%##%#%##%%%%%%%%#%%%%################*##%######*%###%%####%##########*+:                                  ");
            Console.WriteLine("             @#          @#       =@:   *@.   *%       *%.  *@. .@=     @%  -@   #@.   :@   #%   #%                     *@.                                             +**##+==-=+****###%######%##%%%%%%#%%%%#%##%%##%%#%#####%##%##########*%####%##*#######%###*:                                 ");
            Console.WriteLine("            #%.          @#       =@:   *@.   *%       %#*@%-   .@*     @#  -@   #@.   :@   %##@%:                       @@                                           .***#+:::---=++***##**#######%%%%%##%%%%%%###%##%####%#############*##############**#####%%##*-:                                ");
            Console.WriteLine("           =@:           @#       =@:   *@.   *%       %@##*+-   +@+   #@.  -@   #@.   :@   %%#**=.                      .@*                                          .***:.:::::-====+++*******##############%##%##########%%###*############+####%###***##########++:                               ");
            Console.WriteLine("           @+            -:       .=    :-    :-       %#   .#@   .=**+:    .=   :-     -  .@+   :@#                      +@                                         .-*+..::::::::-----==+++******#############################%#%##+##########**####***##*#########**:                              ");
            Console.WriteLine("          *@.                                         :@+   .%%                            -@-   :@*                       @@                                        -*+..:::::::::::-----===+++++********################*#####%#%%*=*##########**##**###**#######%%##+:                             ");
            Console.WriteLine("          @*                                            -#%#+                                =#%#=                         :@=                                     .=*=::::::-:---::-----======++++++*+**###########****#***########%#*+**+*######****####**###########+-.                            ");
            Console.WriteLine("         =@                                                                                                                 %+                                     :*+.::-:::::::::--------=======++++++++*+******+++==******##########*#*****+##*+#+**##**######**####**:                            ");
            Console.WriteLine("        .@+                                                                                                                 +@                                    :+=:::::::-:::::::------==============+++=++++====-=--+===+***#####%##%#=**+***+*#*+#**#*###########%#*+-                           ");
            Console.WriteLine("        +@:                                                                                                                  @#                                   -=:--:----:::::::------======+=================----=-:-===++**#######*###%%**=+*****+#*#*#####*#########+                           ");
            Console.WriteLine("        #@               .                                                                               ..                  *@                                 .==--:::-----------------===========-==========---------======+++***##**+*****#*++*+*++#*#*###*#*#######*#+.                          ");
            Console.WriteLine("        @+              .@=                                                                  #@:   .     #%                  =@=                                -*=-=---:=-------:::-==============--===-=======-----=--------===++++***+********++*+*++*##*####+#%*##*#*#*:                          ");
            Console.WriteLine("       :@:              .@=                                                                       .@.    #%                   @=                               .==-=::-----=--------=--===========--=-----------:-----------------==+++=+++*++###*++*#+=#*##*##*####*#*#*##*:                         ");
            Console.WriteLine("       =@               .@#%%%@%    =@@#%@%.   @-%%%@*.%%%@#    *@#*@%.      =@:   #@.   +@  -@  %@@@@@  #%#@#@@-             @=                               -==----:--=+++===============+======-------=-----------:-------------====-=+=++++**+***#*****###*####**#**##*=                         ");
            Console.WriteLine("       @#               .@*   :@+  =@:    %%   @#   :@*   -@-  %%    =@.      @%  :@%%  .@=  -@   .@.    #%    %%             @@                               ==---==---:---------============-===========--------------------------===----====++*#*#***+*###**##*#*****##+-                         ");
            Console.WriteLine("       @#               .@=   .@+  @%     =@.  @*   .@+   :@= .@@@@@@@@:      .@= +#:@= +@   -@   .@.    #%    %@             @@                              :==-----------====-==================---========------------------------==------===+**###*#**%#+***%*+#*#*#*#*+.                        ");
            Console.WriteLine("      :@=               .@=   .@+  %@     #@   @*   .@+   :@=  @*              #%:@. %% @-   -@   .@.    #%    %@              @                              ---------==================================--====---=-----===-----------------=-===+*+####*+#####**#**+*****##*:                        ");
            Console.WriteLine("      :@=               .@=   .@+   @@.  +@=   @*   .@+   :@=  -@*   .=        .@@#   @@%    -@    @#    #%    %@              @                              :--------------------=-=====++==============-==--=+======----+=------==--==---=====+++**###***%###*#####****#*+:                        ");
            Console.WriteLine("      :@=                .     .     .=+=.     .           .     .=+=.           .                  =+:                        @                               -------:-----------==============-===++===========-=+=======--=+=-------=----===++=+++#*#**###*##*#####*******.                        ");
            Console.WriteLine("      :@=                                                                                                                      @                               ----------------=============================------==-==+====---===-=-----====+++++++*******###*##%*#####+*##+:                        ");
            Console.WriteLine("      :@=                                                                                                                      @                               -------=======--------======+=======----=====++=====---==-=+=====--===========++++++++++****#####%#****##***+*.                        ");
            Console.WriteLine("       @+                                                                                                                     :@                               -:-=-========+=====-===================--=---------===--=----+====---========++++++*********#*###%##*#**#****-                         ");
            Console.WriteLine("       @#                                                                                                                     @@                              .-==+**+++==++++++++===+============-==----==---=-------======---==============++++++****+*#*#*#*######*##**#*:                         ");
            Console.WriteLine("       @#                                                                                                                     @@                              =++=*#*#***++++++++++++=+===+============------=-=+++====--======-=========+=+=+++++***##******##*####**##****                          ");
            Console.WriteLine("       =@                                                                                                                     @=                              =+++*#***######***+++++++=+++=====================-------===-==============++++++++******#+***+##+#####*##*+*=                          ");
            Console.WriteLine("       .@-                                                      .@%                                                          -@=                             :====++*#%##%%%###***++++++++=+++==+++++++===============----=====++===+++==+++++********#*****+***##*#*###**+.                          ");
            Console.WriteLine("        @#                   .    ..                     ..               .                                                  =@-                             ---=====+***##%###****++++++++++++++++++++++++++====================++======++++*++*********#**+*#*##+**##*#*+                           ");
            Console.WriteLine("        #@.             .@+@#%@#-@#%@#  #@.    @*      +@#=%@@%  @#   @*@%*@@:                                               .@@                             ---=++++===++***###****++++*+++++++++++++++++++++++=========+================+++++********+**+*+*#*##**###**++                           ");
            Console.WriteLine("        =@-             .@+   -@=   +@:  @%   %%      .@+   *@   @%  .%#    @#                                                 +@-                          ===*%%%%%%@@@%#**********++**+++++++*****#####*******++++++++==+====++===+++++==+++*****##*#**+*+**#*#**##*#**-                           ");
            Console.WriteLine("         @*             .@=   -@-   =@:  :@= -@-       %%. -@*   @#  .@*    @%                                                  -@+                        .==++###==*%%%%%@@%#*****+++++++++*+******####%%%####*******+++++++=-=++==++=+++++++++**+####*#++*****#####**#*                            ");
            Console.WriteLine("         +@.            .@=   -@-   =@:   *%.%#       :@===-     @%  .@*    @%                                                   :@*                       :-=++++**++#%%%%@%#%###**++++++++**********#####%##%%%###******+++++==++++++++++++++++++*+**********##*##**#*#+                            ");
            Console.WriteLine("          %#            .@=   -@-   =@:    %@%         %@@@%#=   @%  .@*    @%                                                     %%                      ==++==+++**+*###*###%*##*+==+++++****************############****+++++=+++++++++++++++++********#**###*##***#+-                            ");
            Console.WriteLine("          +@:                              =@-        -@:    @#                                                                     @@                    --=======+**########******+==++++++++**********++++++**+************+++=+++++++++++++=+++++**********#%#*##***+                             ");
            Console.WriteLine("           @*                             .@#         =@*  .*@-                                                                      *@.                 .-=-==-===++++****###*****+====+++++***********##%%%#*+===+*+*********+++++++++++++++==++++***##*****####**#**+.                             ");
            Console.WriteLine("           .@=                            .:            .:::.                                                                         -@+                :=====++++*****#*******+++=======++*******####*#####**#%%%%#==+*****+*+++++++++++++=++===++++**************#**:                              ");
            Console.WriteLine("            #@.                                                                                                                        .@#               ==--=+=+++++++++*++++++++=--=---=++**********#####*+=+#%%@%@%@*=+++++++++++++++++++++====++++***********#***++                               ");
            Console.WriteLine("             @#                                                                                                                         .@%              =====+++==+++++++++++=++=-----==+++*****************++*%%##*##*%*++++*+++++++++++++++====+++******#******+==--                               ");
            Console.WriteLine("             .@#                                                                                                                          *@-           :========+=+=++++=+++====--::--===+++*+******************###**######**+++++++++++++==++==+**++*+#*****+*++====-.                              ");
            Console.WriteLine("              -@=                                                                                                                          =@=          :==-============++=+===-::::-=====++++**************+*****************++**++++++==++====+++****+*+**+++++*####*.                              ");
            Console.WriteLine("               =@=                                                                                                                          :@*         ==-============+=====--:::---======+++*****++**********+++*+*+++++++******++===+++++++=++=+***#*++++==*+=*####+                               ");
            Console.WriteLine("                +@:                                                                                                                           @@:       -=-============+++++-:::::::---=====+++++******+**********+****++++++***++==+++++===++====+*#****++===++=####*                                ");
            Console.WriteLine("                 =@=                                                                                                    ....---+***%@@@@@@@%%%**:       ===-=-=======+++***-:::---:-:---====+++++++++++++++*****+***+++++++++++++=+++====+++==+++++**+*++==**+=+=###*                                 ");
            Console.WriteLine("                  -@=                                                                                             +@@@@@%%%#=--.                       .==---=====+++**#*-:------------==+++++++++++++++++++*++++********+===++===++==+=-===+++++++*#***+=###*++=#*=                                  ");
            Console.WriteLine("                   -@*                                                                                           +@=                                   .===-=-===++**#%-:--------------===+*+****+++++++++++++++++++**++++++====++==+==++==+=++++++*#*+#-*###*++=*+                                   ");
            Console.WriteLine("                     %%.                                                                                        *@:                                    ===--===+++**##*---==================+++***++++++++++++++++++++++++===++==++==+==++=++++++******--=*###*++*                                    ");
            Console.WriteLine("                      #@=                                                                                     :@#                                      :==-====+***####++==++++====+========-=++****+++++==============+=+++==+++==+==+++===+++++*****+---####*+*:                                    ");
            Console.WriteLine("                       =@#.                                                                                  +@*                                       *-=-===++**###***##++********+*++++=====+*****+++++++========+==+++==+++++++++==+===++++++****+=--*####*=+                                     ");
            Console.WriteLine("                         #@-                                                                               .@@:                                        =====+++**##***#*##%#**********###****+++**#***+++++==============+====++=+++++===++++++*******=-**##*+++:                                     ");
            Console.WriteLine("                          .@@.                                                                            @@-                                          -==-==++***#*##%#%%%%%%***#####%%%%%%#***###*****+++++=================+++=++++=+++++++*******+=#*+==++++                                      ");
            Console.WriteLine("                            -@%.                                                                        %@%                                           .*++=++*++***####%%%%%%%%%%###%%%%%%%%%%####*******+++++++===+++++===+===+++++++++++++*********+=++====++-                                      ");
            Console.WriteLine("                              =@#                                                                     *@*.                                             +*==**+*#######%%%%%%%%%%%%%%%%@%%%%%%#####*#*******++++++=++=+++==+=====+++++==+++++*********-+==+++==+                                       ");
            Console.WriteLine("                                +@%:                                                               .#@#.                                               +**+++*########%%%%%%%%%%%%%%%%@%%%@%%#######**********++++++++++++++++++++++++++++**********==++==+*+=                                        ");
            Console.WriteLine("                                  -@@=                                                           -@@=                                                  +***+*###%%#####%%#%%%%%%%%%%#%%%%%%##%%##*####*********+++++++++++=+++==+=+++++++********##*===+==+*+                                         ");
            Console.WriteLine("                                     #@@.                                                      #@%                                                     -****###%%############%%%%%%%%%%%%%%%##%#%#%%###***********+++++++=+++++++++++*****#*#******+=+=+*++=.                                         ");
            Console.WriteLine("                                       :%@%=                                               .#@@=                                                       =#**+####%%%%%#%#############%%%#%#%%%%%%%##%%###************+**+++++++*++++++********#****++*++==++=                                          ");
            Console.WriteLine("                                          :*@@#-                                       -*%@*:                                                          .****###%%%%%%###**###############%%%%#%%##%##%#####*************+*+++++++++*******#**#***+**#**+*+:                                           ");
            Console.WriteLine("                                              -*@@#+:                             :=%@@#=                                                              .#*#*####%%%%#*++**++++***########%####%###%%%%######************++*+*+**++*********####***= =-=:-                                             ");
            Console.WriteLine("                                                   =#%@@@*=::...        ...:-*@@@%#=:                                                                   *#***###%%%#++++*#######*****####%##%#%%###%%%#%#####***************************#####**#*+   : :                                              ");
            Console.WriteLine("                                                          -=#@@@@@@@@@@@@@%=-                                                                 .         -*#####%%%#*+*++**##############*########%%%%%%%#%%%#********#*****#**********##**+*###**:                                                    ");
            Console.WriteLine("                                                                                                                                              .         *#######%#*++++**+################**#########%%%%%%%##**#******###*#*****##*****#**##***+                                                     ");
            Console.WriteLine("                                                                                                                                                        -####%####*++++*****####*############**######%%%%@%%##**######*#####****##***###***###*+=+.                                                   ");
            Console.WriteLine("                                                                                                                                                        ++########********#########%####****#****####%%%%%%%####*#################*#******#***+==@%*                                                  ");
            Console.WriteLine("                                                                                                                                                         :*####%###*###***###%%#%######***********##%%%%%%%%###############**####*****##****++==+@%%#.                                                ");
            Console.WriteLine("                                                                                                                                                         *##**#*#****##***##############****#*#**####%%%%%######################*****####***+++=%%@%##:                                               ");
            Console.WriteLine("                                                                                                                                               .      .*##%#*#####*##########*##%####################%%%%#%%##################*############*+++=@@%@%%#:                                              ");
            Console.WriteLine("                                                                                                                                               .    .*#*#@####***%###*******###%######%############%#%%%%######%%#%%#########*##%###%#****#**++*@@@%%%%#                                              ");
            Console.WriteLine("                                                                                                                                               .  .+*%%@@%%###%###**#*#**#***###%############%######%#%#####%%%%###########*##%###%#**###**++++#@@@@%%#*+                                             ");
            Console.WriteLine("                                                                                                                                               . *#%%%%%%*%%#%#****##***#*###################%%##%%##%#%#####%%%%#%#%#########%%#####%##*******#@%@@@%%%#+                                            ");
            Console.WriteLine("                                                                                                                                              .*#%%%##**#%@@%%%+*+**+*%*#*#*#######%%%######%%#*##%%###%##%#%%%###%##%######%%%###%%%#*********#%@%%@%@%##:                                           ");
            Console.WriteLine("                                                                                                                                             *#%%#=#%*##%@@@@%%*%+=##*##*+#+##%####%####%%##%%##*%#%%#####*##%%%##%%#######%##########********#%%@@@%#%%%##.                                          ");
            Console.WriteLine("                                                                                                                                           -+**+*#@**%@@@%@%@@%***##***###*+*###%###%#####%%%%###%#%%###%###%##%#%########%######%%********#*#%%%@@@%#@@%**#                                          ");
            Console.WriteLine("                                                                                                                                         .*##++#%%##%@@@@@%@@@@%%%#*###*##**%#*%%%%#%#%###%######%%#%##%##%##%%%%%#%%%#####%#####*********#*##%%%@@@%=##@%##+-                                        ");
            Console.WriteLine("                                                                                                                                        +**-=*@@#*#@@%@@@%@@@@@@%*+#%+**+#*#%*#**%###%####*%%#%%#%%%%#%%###%%%#%%#%#%#%#%%###%%%#*#****##***#####@@@%*#=%%#*#=+==.                                    ");
            Console.WriteLine("                                                                                                                                      -*%*-+%*%+*@%%@@%+#%@@%@@@#***#*#+*%%%%**##%%%%#%%%#%#%#%%%%@#%%%%#%%%%%%#%%%%#%%%%%%%%###******##***#####%@@%%+*==*+=**##*#*=:                                 ");
            Console.WriteLine("                                                                                                                                  :***++.:+@%**%@@@%@%#%%@@@@@@@#***++%%%%#%%@####%#####@#%%%*%%*%%##%@%%%%%%%%%%%%%%#@%%@%##%###***##****######%@%%@+#*=%%%#%:#++%*=:*-                              ");
            Console.WriteLine("                                                                                                                              .--:=+*%%#%@%%-=%@%@@%+%@@@%@%%@@@#***++=#%#%%%%%#*%%%%%#%%#@%%%%%#@#%%%%%%%#%%%%%@%%%#%%%%%#%#*****###******#####@@#%#+*=.=+=+%*=%*##%#=*#*.                      . .  ");
            Console.WriteLine("                                                                                                                        ::::-++#%+%#@@@@@@*=%@#@@%%%@%%@@@%@@@@@#****++=*#%@@%%#%#%%%@@%@@%%%%#%%@%%%%%#%###%#%%%#%%@%%####*#***###*****###*#*#%@#%%#-%@--%%##+.*#=##*%*.:*#=                         ");
            Console.WriteLine("                                                                                                                    -=*++#*++=*%*%@@@@@@@@%:%@@#@#%@@@%#@@%@@@@@#****+++=+*#%%@@%%%%%%%%%%%%%%%#%%%#%#%##%%#%%%##%@%%####**#**###******#*****#%@@#%%+=%%=-#%*#%=-#%+%%#%%#=+###-                      ");
            Console.WriteLine("                                                                                                             ::.=*#*=*=*#-#%= +%*@@@@@@@@@@%%%@%#@@@@@@@%%%@%@@@%*****+++=++*##%@@%%%%%%%%#%%%%#%%%%%#%%%####%%%%%%%##*****#*###************#%%@###%+*#*= -=*#%*:##**+=**+-++-##=:-:                  ");
            Console.WriteLine("                                                                                                    .:+*==###+##+=###===#%#*-=@@@@%*%@@@@@@#*+%#@@%%@@@@%*@@@@@@@#*****++=++++**##%@%%%%%%%%%%%%%%##%%%%%#####%%####***#***##*************#%@%%%#%@%:%##*:+%%**=:#*%+%%#%%*+%%#=*##-=+.               ");
            Console.WriteLine("                                                                                             .-=+**+-=+++=-++++++-=+*+*#:=%+-%@@@@@@@@@@@@%##*+#%#@@@%##@@@@%@@@@@******+++++++***####%%%%%%#%%%##############%#**#*****####*******#*****#%@%@%#%%%=-@@@@%#**###-+=*#*%*#%=+%%###%#%+.:*+             ");
            Console.WriteLine("                                                                                       .--=+###+:-**+***..*###%*-+%%#**#=#*:-%@%@@@@@@@@#@@*%*%*%%%@%*%@@@%%@@@@@@@******++++++++***####%%%%#%%%%##%%##%%#####**##*######********#*****#%%%@##%#%%%:*@@@@@@@@#+=-+#*=**=*#--*####+++*%##=-+=          ");
            Console.WriteLine("                                                                                    .+*-:*###++--%%###*--#%%%#=:*%%##%#*%%++@#*@@@@%@@%@@@@%@@%@*@@#*@@%@@@@@%@@@@@@#+****+++++++++*****#####%##%%####################*********########%%%%**%*%*+*:@@@@@@@@@@@@# =#+=*#-%-*%%%###=#%%%#%##:.=:       ");
            Console.WriteLine("                                                                                -=+#*%* +*=*%*-+%#*+##.=*==*%*=#%+=+*+==*#+#%#@@@%%@@%%@@@%%@@%@%@@%@@@#%@@@@@@@@@@@@%****++++++*++++**#****#*#####################**#*####*###*#####%%@%*+*##-%%%#%@@@@@@@@@@@@%@%*+-+#-#-*%%%%%%=-*#*-==++**-*#.    ");
            Console.WriteLine("                                                                            -==+*-#%##*=%#%%- #%#**##:-#*#%@+.#%%##*+#%%@=+#+=-@@@@@@@@@@@@@@@%@@@@@#%@@#%@@%#%@@@@@@@@*****+++++++++=++*****################*##*********#***######%@@%****#%+=%%%@@@@@@@@@@@@@@%%@@%=*= = -##++*#. =%*:*####*#- =*=  ");
            Console.WriteLine("                                                                           +#=#%*:++**@=*#-.+%%*====  -+%%%+=#%#**+-#%%%*+%%%##%%@@@%@@@@@@@@@%+%+*%*%@@@##%@@@@@@@@@@@@%****++++++++++++++*********************************####%%@%#******#%+=#@@@@@@@@@@@@@@@@%@@@@=++:*-+%%%%@%-:%##-+*+=++=:*++#*+");
            Console.WriteLine("                                                                          -+%%%#*.+###%*#=-**+###%%--#%%#*+=#%#**=:###*%+#%%#%%%@@@@@@@@@%%@@@%@%@%@%@%%%@%#%@@@@@@@@@@@@%#**++++++++++++++++***************************######%@@%#****#**@%%##@@@@@@@@@@@%%@@@@%@@@@%#=-*++%%%%@%.-++*-+%%#%%%=.##=##");
            Console.WriteLine("                                                                        .-=--##*##-#*+*#+-*%###*== .++*%%+=+++*%+:#%%%@++**++**::#%@@@@@@@@@@@%@#@#@%@@@@@@@%**%@@@@@@@@@@%%#*+++++++++**++++++***********************###*#%@@%#***##****#%%#%@%%@@@@@@@@@%@@@%%%@@@@@@*:*#-++++#%=*%%#-+%%##*+  *#=+-");
            Console.WriteLine("                                                                       :+=+#+..=%#-.%%%= ==+####%=:%%%%#.-###*+= -*+#@**@%%#%%%=+#@@@@@@%@@@@@*%%##%%@@%@@@#%@%*%@%@@@@@@@@@%%*++++++++++*+++++++*******************##*##%@%#***###**+*#*+*#@#@@@@@@@@@@@@%@@@@@%@@@@@%#=%#+%%#%%@+*###::=*#%%@-=#=.+#");
            Console.WriteLine("                                                                    :-=###*-#%%=*++:%#%-+#%##+#%--%%#%#==#@%###.-%%%@#-%@@%%%*:+=@@@@@@@%@@%@%#@%@@%@%@@++@@@@@@#%@%%@@@@@@@@%%%*++++++++++++++++++************#*****#@@@##**##**++**#%+*@@@%@@%@%%%%%#%%#*#%%@%%@@@@%#*=%%#%%##%@+#@###+%%%%%@=##*-%*");
            Console.WriteLine("                                                  .-=+*##%%%%%%%%%%%%#.=*@@%%%##*#*:*%%:*+#%%%%: +==-=:=%%##%#+-*@%%@+#%%#%%%=*-##%@@@@#@@@@@##@%@#%%@%@@@#%@@@@@@#@%%#@@@@@@@@%%%*++++*+++**++*+*****************%%@@##*###*****+*##%#*=*%%@%@%@@@@@@@@@@%@@@%##@@@@@#=:**#*+*###-+%%%*.#%##%%#%##-#%");
            Console.WriteLine("                                          :+*%%%%%%%%%%%%%%%%%%%%%%%%+#+-=%%*:*##%#:-+*#%#**+*=-%%%%%--*##*#%%-:#%@@#+%%###%=%=#@@@@%@%#@@@@@*%@###*@%@%@@@%*%@%#%%@%%%%##@@@@@@@#%%+++++*+*******++*****##****%@@@%*************#%%@@%%@+%%%@@@@@%@@@@@@%#@@@@%%@@%@@#++@%#*%%#%@+#%%%#:+#*=+++*%#+#*");
            Console.WriteLine("                                      -#%%%%%%%%%%%%%%%%%%%%%%%%%%@%++*###%%#*=+###-+@###*%%%-.====+ .**#*%%%++@@%#*+%%%#%*=%#*%@@@@@@*%%#%%#+#%%@@+%%@@@@%@@+=#@@@@@%%%%%%##%@@@@@*%%+++++++*++***++****+**#@@%#****++**+*+*##%@@@@@%#@%#@@@@@@@@@@@@@@@#%@@@@%%@%%@%@+*%#%###%%@+#%*+= =%%#%%#*%%#+#");
            Console.WriteLine("                                    +%%%%%%%%%%%%%%%%%%%%%%%%%%%%*==+*#%##%%*%#%+#%-=%#%#%%%-:#%%%%+:*%%##*++-#@@%%=***+*%=#+-=###%@@%#@@@@@*#@@%%@-%#*@#%@@@@@*#@@@@%%%%%%%%%##%@@@@*%#+++++++++++++***#%@%##**********##%%%@@@@@@%#%@@+#@@@@%##*@@%##%#+*%#%@%%@%##%@+#@%%%+=+++.=%@%*-**=-#%+*%++-*");
            Console.WriteLine("                                  +@%%%%%%%%%%%%%%%%%%%%%%%@*:*#:*##%+  =*#@@##%=-.-=@*---+=:*%%###:-###*%%%=###@@+=%%%#%*#@#*@@@@@@@**%%%#=:+**++%+@%%@@%%@@@@@%**#%%%%%%%%%%%%%%##*###%#**#*******#%%%%##########%%%%%%%@@@@@@%%##+#@%#@@@@@@@%@@@@@@@%#%@@@@*#%@@@@@=**+==-#%%@=*@%%+.*%%%%# .%%+:+");
            Console.WriteLine("                                .%%%%%%%%%%%%%%%%%%%%%%%%@+ ++=.*#%*.=%+-#%%@@#-*%%++###%%+.-+=-==:-#%%#%%%++@@%#- ++*+*+#%@**%@%%%@@%@@@@@+#@@@%@@+#@%@@@@*##%%##*%@@%%#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%####%%%%%%%%%%%%%@@@@@%%%####%%@%*#%@@@@@%%%@@@@@@%#@@@@@#%@@%%%%+%@@%%:=##%=+@@@+-#%##%@-*@@=-#");
            Console.WriteLine("                           .   .%%%%%%%%%%%%%%%%%%%%%%%%%-+###*%*- +%%%*=.:+#*#-=+%%###%%%::%%%%%+:*#*=+#%*+@%%%#-*@%%%####*=*%%@%@@@%@@@%#+#@%%%@%+%%#=%#%%%#%@@@@**@@%%#%%%%%%%@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@%%%%%######%@%@@#@@%%%#*#*%##**#+=%###%#%@@%@%%=@%%%#-=#%@=*%#*-.+=+#%*:#@@=*#");
            Console.WriteLine("                              =%%%%%%%%%%%%%%%%%%%%%%%%%#*##+:=%%=#==-:+%%#*%@%%%*-+#*===  *#%%%*:*%%%#@%+.#%%%@+-#%##+-*%%#+%%%#%##*#@@@@%+@%%#%%*-*%@+%%%@@@*#@@@@#*@%%%%%%%#%%%#%%%%%%%@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%##########*%%@@%#@@%@%%@#%@@%@@@**@@@@%+##%%@%#-%%**= =#** =%@@+-%%%#*=-%@#:+*");
            Console.WriteLine("                             -%%%%%%%%%%%%%%%%%%%%%%%%%%=*.=+%%#%*%+:=-**###+@@#%=-=#%#%*-*%#+=- .#%%%%%%=+%*++*:*%%**-%%%@**@@%#%@@*@@##*+:%#%%@@*+@%@=@%%%@@@%#@%@@*=@%%%%%%#%##%##%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#######*##%%###%##@@@*#@%@%#@%*%@%#%%@+#@%%%#+@@@%##=-%@@@*-#*%%-+%%@+-%%%#%:.*%@*%%");
            Console.WriteLine("                            =%%%%%%%%%%%%%%%%%%%%%%%%@#+*+%*##+%%+#=%%%*+%+:-.+*%-#%%###::%%%%%+-#@%=+*%==@%%%%+=%%%#*+%***=#@@%%@%#*%@@@@*+@%%@@@#+@@%:+*%%*@%#%+@@%%@#%#####%%%%%%%%#####################*#########%%%%%#****%%*@@@@%#@%@%%@@%#@@@%%@%=%@@@@#+%%%%%@++@@%%=-%%*#-+%#*::#+-+@-*%@@#%%");
            Console.WriteLine("                            +%%%%%%%%%%%%%%%%%%%%%%@*+==*+#%#=- .%%*##%%@.*%%%*#%#%*%#%-.%%%%##:+%%%%%@= =#%%%*-*%%#* *%%%%=#%#**#%==##%@@*%@@%%%*:-*#@+@@@#@+%@@@#@@@@@%%%##########%#%%%%#%%%%%%%%##%%%%%%%%%%%#%#####%#***%%%#@@@@@%%#%%%#%%+-**++**:.#****==%@@%%%-=@%%@+*%%##.=%%@*=%%#%*.#%@@#+=");
            Console.WriteLine("                        .  -%%%%%%%%%%%%%%%%%%%%%%==-**-++*= =%%%#*####%%*=##%%%=###%+= .=+*#%+=%%%%%%%--%%*+=  ===**:%##%#+@%@%%%%+*@@@@#=##%#%%%+%%%%=%%@@%%##@@@#@%#@@%%%#%####%%###########*######*##*#*######%%%###***%*-##%@@@@%%%%@%@@@@**@@%%%@==@@@@@+=%#*+#%-+@%%#:==+#*.#%%%*+%%##%:*=*%#%#");
            Console.WriteLine("                           *%%%%%%%%%%%%%%%%%%@%+*+=#:***%*:##=+%@#=#%%++%#=#=--*+=%%%=:#%%%#+ =#%%%%@-:#%%%%=-%%%#%=-%%%%+=@%%#%%#=@%%@@##@@%%@@#=@%%%+@@@@@@%%*%##*%@@@@%%%%######%%%%%%%%#########%%%#%%%%%%%%%##*****%##%%%@@%%%@##*#%%@@@@+#@%%%%%-+@%%%%==%%#%%* -##%%=%%%*#:#%%@**%##%#-%%%@%%#");
            Console.WriteLine("                     .     #%%%%%%%%%%%%%%%%%@#==:+%=##%#:.#%%#- =#%#+ :#@%- *%%###=#%:=%%%%%=+@%#+*#*:+%%%##-=###%%.-==+*-=%@%%@@+=@@@@@##@%%%@@+=@@@#-###%@@@#%*%@@@%%%@%%%%##########%%%%%%%%%%%%%%%%@%%%%###*******++#@@@%@@@@@@%#+@@####%#:*+==+*+:=##*#*:=%%%%%#:*%%%#+%%%## ####==%#*+*=%#%@%%%");
            Console.WriteLine("                     . ..  #%%%%%%%%%%%%%%%%@#:*%##.-==  #%%%%=*%*#@%#-+=@@#%-##%%%==. =-=#@*=%@%%%%@= --=+*-.**=-=*.%%%@%++%*+++*.-###**=#@@%%%%:-***#+@@@@@@%*#@##%%@*#@@%%%%%###################%%########********###%@%%++@@@@@@%+%%%#@@@@#=@@%%@@#-*@@@@#=*%#==+*=#%%%#=*+=*@=%%%@**@%###:%%%@##*");
            Console.WriteLine("                       .. .#%%%%%%%%%%%%%%%@@=+=.+###%*=%+-#%%*%##**@#*%%#@@@#=#@%=+%:+%%%%* -%@%#%%*:+%%%%*.*%%###-:@%%%%+*@%%%@@-#%@@@#*@@@%@@@+#@@%**@@%@@@%%@%%@*@@@*-%%%%%%###########################**********#@@@@@%%@@%##%#*+%%+%@%@@+*%%##%%*-#%%%%+-#%%#%@+ ==+*+*%%*%*=%#%%#*@%#%%*#++#+%%");
            Console.WriteLine("                      .   .#%%%%%%%%%%%%%%%%-#%=*-:*#-=#%%%+  %@##%%++%%%%@#%%%*-=+@*.*##%%*=@%*-===  *##%#:-#%#**= .===**=#%@%%%@=%@@%@+#@@@%@@#+%%%@*+###%@@##@@%*#=*#%@**@%%%######################***#####*##*+%@@@@@@%#@@@%@@@+:*%%=@@%%%=#@%%%%@=-%%%%%--%%%*#%+-%%%@*#%#*#%=++**=-####*+%%%%#@#");
            Console.WriteLine("               .      ... .%%%%%%%%%%%%%%@%-#%%*%%*.:-=*%+:+#%+#%%*-=-+#%%+@%%%+==%@*=%%%%%-#@%%#%%=:#%%%#-:*#**%%=.#%%%@*-#*++**=.++++=:****###=:**+*-*%@%%@@+*##%%%%#*%%@@#@%#%####################******#*#***%%**@%@@@#@@@%@@@#=#%%--%%%%*:+**+*##-:#%###.=####%@=*###%+#%%%%%=#%%%**@%#%%+%%%*#%-");
            Console.WriteLine("                      ..  .%%%%%%%%%%%%@@#:###*=%%=*#%%*  +%%%#%##=*#%%%+:+%@*-+@@*#::=+#%*=%%#*###.=###*=.*##+*##:.##%%%-+@%%%@@*+%@@@*+@@@%@@@**@%%@+*%%%@@@#@@@%#@%%@+#%***%%############################***%@@#%@@@%%*%@@@@@@@==%%@+#@%%%**%%%#%%%:=%%%@#:*%%#*=*:#%%%%+%%*+*#-#%%%++%%#%#*++=:*#:");
            Console.WriteLine("                 .    ... :%%%%%%%%%%%%@*.=+*-:%@%%##%=.+%#==%%%@%#%%#%%#==%@=%%%@@#=@%%%#.-%@##%%-.%%%%%--%%%#%%#:-%%%%#-#%##%%@++%%%%++%%%%%%@++%%%%+#%@%@%*-=#@%%@@#=*+:@@@%%%################*#**#####*#*+%@@##@@@@@%%@@%%@@%+:#%%%-@%%%@+=%%%#%%#-#%%%%+-#%%#%%%-*+=++-#@#%%% =%%%=+@%%%%%*@*+@%=");
            Console.WriteLine("                     . .. :%%%%%%%%%%@#+-###:+%+=**+@%-#*#%#%==#=###%%%--%%#@%%%%%@#=%%%%%-#%#*##*.:#+*++ .++=+++. =++*#+=%@%%%@@+=@%%@**@%%%@@@++@%@%=%@%@#......:#@@@@%%@++@%%%%######*###############***%@@@%+=%@@@@%#@@@%%@%%++%+*+=@@@@@==###%@@=-@%@@%+=%%%%%%%-@%%%%*@%%%%+:%*=+.:+++#*+.%=*@#+");
            Console.WriteLine("                       .. :%%%%%%%%%@*#-#%%-#%%#%@#-##*%%*##%%+ .#@@**-+%#%%@#@@@#**:+*%%*-%%%#%%%=+@%%%%=+%%##%%--@%%%%==#*++*#%-=%##*-=*#**###-*##*+:%%%%-:::::::.=@@@###%#=%@@%#####################**%%@%@@%#@@%%##+*%@@@@%%*=#%%%==####*-*%#*##*.:**###-:###+++-=@%%%#*@%%##::%%%%-+@%%%%%-#=%@*%");
            Console.WriteLine("                       .  -%%%%%%%@%-= -=+.-*+#%*-=%@%%*#*%%#:-#%*+@@*+%%%##%%#%##%**%#*+ .*#%#@%#=*@%%%%=*@%#%%#:+%%%%%=*%%%%%@#-%%%@%+#%@%%@@*+@@@@%=@%%@=-------::-@@#@%#%%-=#%%#######**######**#*#*#%@@%@@**@@@@@##@%%###%%-+%%%%=#%%%@=-%%%#%%#-+%%%%%-+%%##%%=-+=+*-:#*##*.:+=##:*%%%%%%-==@@++");
            Console.WriteLine("                      ..  =%%%%%%@#*+-##+-##**+. :*#@@%=#@#+  #@%%%*%#%*##%%%@@#@@@+#%%%%=*%%*===: :+++*=.++=-==: -*#%%#=#%%#%%@==@%%%%+#@@%%%@=+@%%@#+@%%@#-====----:+@*@##+*%+*@%%%####*****####*###%##%#%@@##@@@@@#+%%%%%%%%+=%@%%#-%%%%%-=%%####*:+###%*:*%%###%-*%%%@=*@%%%*:*%%#: =++==+=  %@@#%");
            Console.WriteLine("                       .  =%%%%%%%*.##=.*###%%--%%%+=:=%@@%@*%#+#%%==%@@*+%@#+@%*@@=%%##+-*%%%#@@*-#%%%%=+@%#%%%+:#@%%#: +=++*%%==%%%%%+@@%%@@@=*@@%%:+*==+*====++=-=-:@%@@@@%%@#+@%%#####****#######%##@@%@#*-*@@@@@*+@@%%##%*:=*+#@=+@%%%%-*@%%%%%+:*%%%@=-%%%#%%#:#%###-#%%%%*-#####:#%%#%%@--%@@#%");
            Console.WriteLine("                      ..  +%%%%@%#+#* =#%#%%%-:##%%*:+%*++%@##@%%#=+@%@%@%*-=#@@%%@+%%%%*=#%%##%%=-@%%%%=#%%#%%@-:@%%%%-=%%%#@@#:+#*##*-%%%#%%#-*%%@@-@%%%@*:=-==+*-:=--%@@@@@%%@#:%%%#################@@%%@@*+@%%#*-:*%@%%%%%*=%@%@% =++=+= =++====  ===+*.-##*+===:%%%%*-#@%%@*-%%%%*-##%#%#%:-%@@%%");
            Console.WriteLine("                      .   +%%%%*=+=%*+%##*= .+%%%%+:+%%%%%%*--@@@*-*%%%@%%#-=%@@@#%+++++::#%%%%%@==%%%%*-#%%#%@%:=%%%%*-#%%%%%%*-#%%%@++@%%%@@#+%%%%%=#%##%*:--=+==+=:-:#%#%%##+*%%+@%#######***##*%*:+*%%@@*+@%%@@%*#@@%#%%@@=*@%%%*=%%%%@+-%%%#%%@--%%%%#-*%%%#%%*:*++*-.****#--#**+-.#%%#%%%:+%#%%%");
            Console.WriteLine("   .                ...   *%%@*+%%+%+%###--*#+-+#+-#%#**%%%*=%#+#=*@%%%%@%*%@##@@%%%%%%@+=##*=+**:#%##%=:###*##=:#%%%%+=%%%%%%@+=#%%%%++%%%%%%*-#%%%*+%%#%@=====+++=+--:#@@@%@@##%%%+%%#######**###@=*@%*#**-*@@%%@++@@@#++*+: *##%%=+%%%%%=-%%%#%%%:*%%%%#-#%%%%%%==@%%%=-%%%%@*#%%%%*:=+++***:=#%@@@");
            Console.WriteLine("                    ....  *%%++##.##+%##-=%%%%%*. =*###%%%--#%%%*:==*#%%##@@@@%##%@%%%%%-+@%%%%%=-#####-=##*###:.%*+++:.*###%%@=+%%%%%=%%@%%%@*-%%%%==#**#::-===++*+++=-*%@@@@@#+@#%@#%%#########*%=-%%%#@@*-#*+*+-:#%@#%%%%%=*@%#*+ .=-==+  ==--==: -+===: ===-==+:*@%%%-+%%%%%*%%%%%+-#%##%%+:*#*@%%");
            Console.WriteLine(" .                   ...  #%===-:#*-=##+=*=:-=:-%%%#=-=#*:=%##%#-@%%#+=###%@@@@##%@#*#%#=#%%#%%%==@%%%%=*%%#%%%+=%%%%%==%%%##** :+++*-:+**+***..+**#=#@%#*--=====++++==-*#@@%@@%*%@%@#%%#%######*%#*#%%%%%#+%@@%%#=*%%+*###%*-%@#%%#-*%%%%%=#%%#%%%==%%%%%+-%%%#%%%:+++#*-+%%%%%=*==+=.:*###%%=:%%%%%%");
            Console.WriteLine("  .                    .  #**.+###:####-%#%*:=+-#%##%%#. :#%%%%-#%%#%%%= +@@@@#%@@%%%##:.+===*%%=+@%%%%-%%%#@%#=*%%%%%=+%%##%%*=%%%@%*=%%%%%@@-@%%%%=%%%#..-+-==+++++===#*@@@@%*:+##**#%%#########.:*#%%@%++%#%%@*+@@%=%%%%@=+@%%%%=:#%#%%=-%###%%%-=%%##%:=%##*#%*:%%%%+:+#**#@*@%%%%+#@%*--*==%%%*#*");
            Console.WriteLine("                    ...   #-=*%#--%###-###*:*%%##+-*#-:+%%#==%+*@%#%##=-#*+%@@%@@@@%%%%=+@%%%%#+.-====- +=+=+=- :===++:*%%%%%%==@%%%%*+@%%#%@==@%%@#=@%*.:-+*-==+++++==*@*%%%%@@+#@@@%#%%#######%+=@%%#*#*+@%%%@*=%%@=-++++=-%@%%%@=-%%%%%--%%%#%%#:+%%%%#-#%%#%%%=-%%%%--@%%#%@*%##%++@%%#%%#::+==#@@");
            Console.WriteLine("                    ...   *#%=.:==+*#-*%%%=*%#**#%#-  *%%%%%*..=*#%%#--%%%%+*@@@@@@%%%#-*%%#%%%*:#%%%@+=@%%%%@+:%%%%@+-##*++++ -*****:-**+**+ -++*#:-#=.:-=--===++++++#@@@#@@%@@*+@@@@%%%######%#=*%%%%@@-**++**=+@@*:%%%%@=+%#=+++ :*++++ :***+##=.+****. +==-=+*-+%%%%-=%##*%%*@%%%=*@%%#%#*:=%%%#@@");
            Console.WriteLine("                    ...  :%*:*%###%*.:+==:-#%#%%%-.=%%*-=%#--#%%#*++:=%%%%@%-:@@@@@%%%#=#%%%%%%=-%#%%%-+@%#%%%--%%#%%-=%%%#%%#-*@%%%#=#@%#%%*=#%%%@=#+.:---=+==+++++++****+@@@@@%=%%%%#+#%###%#+ .#%@%%@*+@%%%@+-##%=*%%%%#-*%%#%%#:*%%%%#=+%%%%%%-:#%%%%:=%%%#%%#:-*#%*-*%%%#%@*%###-#@@%%%@*:*##%%@@");
            Console.WriteLine("                         =: =+*##+.=%%##--%*=-=+:-%%##%%#  -%%%##%%=-++%%%*++%#%@@%**#=:#%%#%@%-+@%%%%=*%%#%%%-+%%%%#-*@%###%*-*%%%%*=%%%#%%+:%%#%*--.:-==--==+++++++@%%%@=#****#-#@@@@#%%%%#%%+=%%*++#%=@%%%%#-%@%#-#%#%%*-@%%#%%+:#%%%%#-+%%#%%@::%%%%#:*%%##%%*-*%%%= =*+==+*=%%%%:+***#%%==%%%%*@@");
            Console.WriteLine("                       +%+-%%#%*  :+#%#:*%%##%%-:=-#%%%--+%%=-#%%%==%%%*#++%%%@%@@@%@@+*@%#+++= -**#%*=*%%*##-.#%%%%*=#%%%%%%+=%%%%%==@%%%%@-=@%%%+-.:---=====+++++=*%%%%%*@@%@@@+*@@@@%+#%%%##=*@%%%@@:-+=*##=*@%*-:%%@@%::+=--=+: +*###+-#@@%%@%-+@%##=.=+++*#%*:%%%%+-#%%#%%%+%%%%+%@@%@@+-+==+%*@@");
            Console.WriteLine("                      *#=-####+-#%##*  =*%##%%-+%%#*=:-=%##%#%*-===%%%%%=#@@%#%@@@@%@%+#@@%%%%*=%%%%#+-###*%%-=%%%##-.++**##%--@%%@%-#%%+##* *+++*:::--====+=+++++==@@%%%@**%%%%%++@%%@@*%%%%%+=%%%#%@*+%%%%%*:*##%=+%%%%%-#%%%%%%=-%%%%%=:*#*+**- +##%%=:%%%#%##. ++#%+-%@%#%%@+@@%%=%%%%@@+*%%%%%=@@");
            Console.WriteLine("                    -#%==%###--####=:*%%*+-=*--%#%%%=-=+#%###%%#-.=*%%%*+#%%%%@@@@@##%*@%@%%%%+=%%%%%+=%%#%%#:+%%%%@=+@%%#%%#:=#***+:*###%%=-%%%*..:=---====+=+++==*###**%**@%%@%%@%%@@@*##%@*-#@%%%%%=*%%%%%=+%@%#:%%%%%==%%%*%%%--%%%%%=:*#%#@@+-%@%%@-+%%%#%%%-=%%#*  +++=+++.*+++:*%%@@%+%%%%%*+@%");
            Console.WriteLine("                 .=-*=.-=-== =#%%#:=##**#%%+. ==*%#--%%%*+%%%%-:+@%#++==%%##@@@%@@@@%#-++++*##==%%%%%++@%#%%*-#%%%%#=%%%#%%%+-%%%%%+=%%##%%-+@%: :::-==--====++++=+%@@@%%%==##%#%%%@%%##**@%%==#+*#%@%%@%%@@++%%%%==%%%%@++@%%#%%%:=%%%%%==%@%%@@+=####*-#%%##%%*:*%%%@-*%%%%@@*=@%%@=#####*-**##%-*%+");
            Console.WriteLine("               -#*+%#-%##%+:#%+=. =####%%+.:#%%%*= -%%%#%%**#=-%#%%%%+:=#%@@#*%@@@@@%@*@%%%@@#--*++++ :+==++  +=+++..##%#%%%-=@%%%%==%%#%%%-++ ::-::---+====+++++++%@%%%%%*+@%@%%@@%:#@@%+@%#+#%%%%%*+%*##%#=#%@#+ -++++= -*#*#%%*:*%%%%#-%###%%%=*@%%%-+@%%%%%#:-###%#:*%%#%%%++%%%%=#%%@@%%@%%*- +@@");
            Console.WriteLine("             ::-+*%*-%*#%--%%%#:=%%#==-=-=%%#*%%#-+%==#%%%%=.=@%%%##==@@%*@*%@@@@@@@%#+%%%%%@#=*%%%%#-@%%%%%-*%%%%%-+@%%*#++ .====- =+++#%*-...:-::----===++=++*+=+@@@%%%@*=%%%@%%%%@@%%@+@@+*@%%#%%%%%%@@%-.==*%*-%%%%@#=%%@#%#%-.##***-+%%@#%%%-#%%##-+###%%%#=#@@@@#*@@#*+*#=#@@%@-#%%%@#%@@%@-+%%@");
            Console.WriteLine("          .+##=-=*:=*+=: :=*%*:*%%##%#-.==+%%%%-:*%%%#*+%*-=%%**%@#==%%%%%**@@@@@@@%%@*@%#%%%=-%%%%%=-%#*##=.####%*=#%%#%%%*:*%%%%#-%%%#%%= .:.::------=====++**+++%%%#*+=:.#%%@%#==*++**:*: ++#%@@@%%%%%%%-+@%%%==@%%%@=+@%%#%%%-=%%%%#-+#+*+*#=-@%%%*=#%%#%%@+-%%%%%**@%%%%%%=#%%*%#-=*+**%@@@*+%%@@");
            Console.WriteLine("        :+=.:-=*#=###%=:#%##- -=+*%%=.=%%%#+=-:=%%###%%%-.*@%%%%*:-#%%%%#%@=%@@@@@@@%#+%%%@@@=+@%%%%-*%##%%--%%%%%+-#%%###%-:%###%--%###*. ..::-::----+======+**+=+@@@%@%%*=%%*###-+@%%%%##=#%%##***#%%%@%*+%%@@%.+**##*=#@@%%%%*-#%%%%*=#%%#%@%--%#**: ****#%%++@%%@@+#@%#%%%+-#%%%@%+%@@%@@@+=##**+-");
            Console.WriteLine("     .=+--**++*#-###%=.####=-%%###=  +%%%%%*-:=+#%##%#%=-*+#%%%#++#*#@%%@%#+%%@@@@@@%@#%#***-.=**##+.+*+++* .*####==@%%#%%@-=%%%%%-#%%*.. ...:::.::-=+=-=======++=+%%%%%%%*=#%%%%@=+%%%%@%=*%%%#%%%%@##***:-***#--%%%%%-:***++==. -=+=++=%%%#%%#=#@%%@==%%%%%%#.-*+***=*@@%%@@=+@%%%%+=%%%%%@%+#@@@@@*");
            Console.WriteLine("   ...=%%*-#+*#-###%*=%%#*:#**##=:=%%#==#%--+%%%+-#%%#-:#%%*+%+=*@%@%*#%@%=#%%%%@@@@%@%@@%@@+=%@@@%*=%%#%%#-+%@%%#.:*+==++= -+=++- -+......:.........:.:-==--:..=+=%@%%@%%*=#%#%%%=-@%%@%*=%%%#%%%+=%%%%@*=%%%%%-*@%%%@++@%%#%%%--%%%%@:.++**#%*=%%%%%=#%%%%@%*=%%%%%%#%##***+-#@@@@@+*@@%%@@#+%%%%%#+");
            Console.WriteLine(" =##+=:++++:##-##**..-*#%#+-*@*==%%%%%%%: -@%%%#%%#+:-=%%#%%%  %@%%%%@@%--%@%%#@@@@@#*#@%%%%+=%%%%%=*%%#%%*-%%%%%#-#%%#%%@=-@%%%@*+..   .............:::....::...::++*#%%@*=#%%%%%+=@@%%+:*%%@%%%%=#%%%%@=*@%#%*-#%%%%#-+###*###--###%@*+@@%%%%-:+++*-.#%%%@%%=-%%%%@*+@@%%@@+=%%#**=.+#**%%@+#@@@@@*#");
            Console.WriteLine("===:+%%**##-:*##*: :#%%#%%%@*:-%@@%%%@#++%#+*%%%@%%==+*%%%%%==%*=*%%%@%++%*#@%#@@@@@%@%***#%=*@%%%#=@@%%@@*=@%%%%-=@%%#%%%-=%%%%#....  ...............::::....... ..-%@@%#*-+***+*: +**%=-%#+=*#%+*@@@@@*=%%%%@--%%%@@+-%%%#%%%+-#%%%%*=%%%#%%@**%%%@++@%%#%#* :**#%@+#@%%@%%=+@%%%%*+%@%%%%*+%%###+=#");
            Console.WriteLine("#+:=+*#%%=-###%#-=%#+-=#%%%*+%@##%@%%++#@@@@%##%@*+*@%%*+%#=+%%%%*+*%*=#@@@%#*@@@@@@%@@%@@%#-****+.:**+**+.:+++=- .====+++.:*+=.......::............:....:::-:.::....   .*%+#%%%%%%=%@@#*#%%%%@%*:=+++*+.-#%**= -+++==.:+++=++* :####%**@%%%%%%=#@%%%**@@%%@@%+%@@%%*-*#**#%#+#@@%@@=+@%%%%%+#@@@@@*#%");
            Console.WriteLine(":+#%%%*++=%%%%%+*%%%#%%*-.:+%%%%%#*=*#@@%%%@@@@*-+@@%%%@%:.*@%%#%%%%..#@%@@@#%@@@@@@@%@@%%@%+@%%%%-*%%#%%%=%%%%%*-*%%%%%%*-+:  . .....:....::..::.::....:..:..:.........  ..:+*#%#+--++++#%@%%%@=-@%%%@+-%##%%==@%%%%*-#%%#%%%*-#%@%%*:*+++*#%==@%%%#=#%%#%%%+-%@%@@**@@%%@%*-*****+-#%##%@*+%@@@@#*@%");
            Console.WriteLine("-=+###%@=***%@%#@@@%@@@*=*%+=#%%%+==**%%%%%%@%++%%#%@@@#+*%**%%%%%#-+@#*#@@#@@@@@@@@@*%%%@@%+@%%%#=#%%#%%#-%%%%#*-##%#%%%=  .    .........::..:-::::::::....... . ..       ........           :+=%%%%%#*#@@%%%=*@%%%%==%%%#%%@+=%%%%@+#%%%%%%+ -*+*#+=%%%#%%@+*@@@@%*#@%%@@@#*@@@@@**@@@###-+##*##+#%%");
            Console.WriteLine("#@###:.##%@@@%==**#%@@@%%@%%%%+ -=%%%%+=#@%%+-*@%@%#*%*+%@%%%*+%@*-=%%%@@++@@@@@@@@@@@%@%#%@##%@%%*#@%%@@#+%@%%%+=%##%#   .. ............::::-::::::-::-::-::::-::......      ........  ........ -##%@**%%%%%+-+####*-=#%%#%@%=*@%%%*+%%%#%%%=-%%%@%++@#*=+++:*%@%@%*%@@@@@%=*%%#%#=%@%%@@#%@@@@@*%@%@");
            Console.WriteLine("*%#%@%=%*=--.=+%%%%%#*::%@@@%+=#%*=%##%%#+:=+%%%%%@@*-=#@%%#%%@#:-%@%%%@##@%@@@@@@@@@@@@@%@@*+###*=*##*##*-*#######%#:.... . ...:.:.:--..::-:--::::-------:----:::::.......  ..............:::::..:%%%-+***%%==%%%%%==%%%####:.#*++*::==++#@%-+%%%%#=#@%%%%@*=%@%%%=-*##*%@#*%@%%@#=%@%@@##@@@@@##@@%@");
            Console.WriteLine("+#%+#*+-%%%+:###*#%%*++%%#**%#%@@%##+*%%+-:=*%%%%%*++%@#**%%%@#+*%#%@@%*%@@%#@@@@@@@@@%@%#@@@#@@@@#%@@@@@%###%##%%%*:........:::.::.....:::::---=----------==-=-==----:::.... ......:::.:::------:::#==%%%%%#=*@%%@@=*@%%#%%%-*@%%%%=#%%####: =**#%+=%@@%%@@+=%%%@@+#@@%%@%+-###%@+#@%%@#*@@@@@#*%@@%@");
            Console.WriteLine("=*+-%%%*#%%++%%#*#%=:#%%%%@%+-#@@@@@@#..=#%%%++##=-#%%%%##++#+=#@@@%#%%@@@@@@@@@@@@@@@@@@@#%@%#@%*==*#####%%%%%%%%#:.....::...........:..:::::-------------==-=======--::::.::....:::-------======-:-=*%%#%%=-%%%%%*-#%%##%%*-#%#%%+-%%%*%%%:=%%%%#::*+**#%%==%%@@**@@@%@@@+*@@@%%=@%%@%*%%%##*=%%%%%@");
            Console.WriteLine("%*+%%%*-##+:*%%%%%%+:==+#%++#@@#*#%@%**#+%%%%%#. +@%%#*#%%%+.:%@@@@%%%@@@@@@@@@@@@@@@@@@@@#*=++.=#####%%%%%%%%%%%%*:...:-::::..:-..:. . .:..:::----::-----::-::--=-----:.....-::-==+++=+===+=======---#%%%%%=*@%%%%+=%%%#%%@=:%%%%@=*%%%%%%*:*%%%%#=+%%%%@@%-+****-=##%%@@%+%@@%@#=@%%@##@@@@%*%@%@%@@");
            Console.WriteLine(":=**:+%%%%=+%%#**++  ==**  +@@@%%%@%#@@@%+*@%=-*%*+##%%%#+-=@@%@@@@@@%%@@@@@@@@@@@@@#***-:*##+:%%%%%%%%%%%%%%%%%%%+....:......... . .. ...::::::::::.:::::::::::::::--::::====+**++**++++++=========:.+*+++= -+++++ :+++=+*+ -+=++=:=*##%%%+-%%%%%=-#%%#%@@++@%%%%+#@@%%%#+:#%@@@**@%%@*%@@@@#*@@%@@@@");
            Console.WriteLine("##+.#%%%%#+@%%%%@@#=%@%%%+ =*-#%%@#+*@@@@@#:-#@%%%%*=*@%=+%@@@@%%@@@@@%@@@@@%+=*+:++--:  -+*::%%%%%%%%%%%%%%%%%%%%+:...:...:.::::---::::--::::----::::.......::---.:-==+++*#**+++**+++**++++=+==++++=%%@%%@+=%@%%@*-%%%%%%%=-%%%%@**%%%##+*  **%@%=+%%%#%@%+*@%%%#=%@@%@@@*#@@@%#:-*+*#=%%##=-%@@%@@@@");
            Console.WriteLine("==+**+==**+--=*#*+=+%%%#+:+%##%*=.:*%@@@####*#*- ..:-. +####@@@@@%@@@@%**=..-== =#**#*.*###-.@%%%%%%%%%%%%%%%%%%%%+::....:::::::::----:::::----------==--:::.....:-=+++++++++++********+++++++++++*+#%@%%%@-+@%%%@=+@%%#%%%==@%%%@**%%##%%#:+%%##- =*#*#%@*=%@%%@#=@%%%@@%*%@%@@%*#@@#@*@@@%*#@%%@@@@@");
            Console.WriteLine("+%%%%%%#-.-==#%%%#+-. -#%%#%%##%+-+**=-*#%*#%#==%%%*+*#=:##*##-##*=-=++*-:#*#- **+*#+ =###=.%@%%%%%%%%%%%%%%%%%%%%+-::::::::::::-+=-----:::::::-:----------==---===+++++++++++++++##***######***##+=#%%#%%*-##%###=*%%%%%%#=*@%%%%=%%%#%%%=-%%%%%+=%%%#%*#:.+*###+=%%%%@@#+%@@@@#+%%%#%+@@@#*@@@@%%@##");
            Console.WriteLine("%%@@@@@%%@@@@@%%%%%#**#+####**#*+###:.::..+##==###*-*%%%=%%+:.+*+:**+**::###+ *#####.:###* =@%%%%%%%%%%%%%%%%%%%%%*-------:::::::::-:::::::::-::::---===+++++++++++=============-=+#**+++===++%@@@*#%#*###--%####+-*##*##**-*##**+=#*+=+++ :%%%%%==%%%#%%@-=%%%@@==%#*###=-%%@@@**@@@%@#@@%#@@@@@%@@%@");
            Console.WriteLine("#+--+*: *%*=*###%#-=*==*%%##+-##***:+%#%#*-.  .-+-*= **+-.: **#*:#%###::%#*= :-::--  ++##:-@@%%%%%%%%%%%%%%%%%%%%%#+=---------:-:.....::-------=====+++=++++=======---::---:--------------==++@%@==@%@#%%%-+%%%@@++@%@%@@@*+@@@@@+#@%%%%%#=*#*=== :%%%%%%*-#%%%%#=#%%%@@@#%@%##*:+######**#@@@@%#@@@@%");
            Console.WriteLine("*%##%##=  :=%%%#==%%%%+:.-==+#%%%#-+#***#%+-####--:**.*#=:.###* --:-=: +##%::##*##* +##%* #@@%%%%%%%%%%%%%%%%%%%%%%*==---::--:-----:---================-----====+=---::::.::.::::--::----=+**%%%*-+%%###%+=#%%%%#=#%%%%%%%+#%%%%*+#%%%%%@*=#%%%%%-+%#++++-.#%%@@+=%@%%%@%+%@@@@#*@@@%@@%*%@@@@%@@@@@@@");
            Console.WriteLine("#**=:--#%%*-::=+%%#****#%#- :::--.+#%##%#-+#*#=-*=#####-: -+**.+#####.*%##*.#%#*%%::%%%%-:@@@%%%%%%%%%%%%%%%%%%%%%%#+:--::::------===============-=---::--------=---::::... ....:::--==++***%%@%*=%%%%%@@+*@@@@@+*@@@%@@@*+@%@%@#*%%%%%%@+-%%##%#-#%%*%%%-=%#*#+..++++##==@@@@@**@@@%@@%+%*%@@%@@@@@%+");
            Console.WriteLine("%%%+-*%%#%%*-.:-=+#####%%#=*%%*+ -:..:-..====:*%+-+#%%=-.=###:=%#*##::%###::#*+++- .-=== +@@%%%%%%%%%%%%%%%%%%%%%%%%#+----:------=-----====----:------------------:--:::..::::::::-=+******#####-=###+*#=.*#**#*-+###**##:-##*##=-####@@@=+@%%%@*-%%#*#%#-*@%@@%**%%%%%%=+%#***=*%%@%@@#*%#=*#%@@@%%@#");
            Console.WriteLine("%*-.:.=#%*-=%##+  =+*#@%%++###*:*##*##-####: ::.:+-:-::.=#*#+ ++----  ==== =*#*%%=.####+:@@@@%%%%%%%%%%%%%%%%%%%%%%%##+==-::-:----------------------===--===--=-----:::.::::----==********@@@@@##@@@%@@@**@@@@@#*%@@%%@@%=*@@@@@*%@%####+.+##%%%+*@@%#%%*:+%#%%#+%%%%%%%+#@@@@%*######%=+%@%*@@%@@%%%*");
            Console.WriteLine("*=%%#%=  .#%**%+=#*=::=:-:##%#-%####+-####-=%##**%%#*.. -=+*-=%%#%%*:*%%%+.*%##%#--###* =@@@@%%%%%%%%%%%%%%%%@%%%%%%%##+++++--------============+============+=+++++===+=++==++********++%@@@@@#%@@@%%@%*#@@@%@*+@%%%%@@+=%@%%@**@%%%%%@+=@@@%%*:=****#%*:*%%%%=+@@%%%%*=%@%%@#*%%@%@@@+%@@%+@%%#@%@%=");
            Console.WriteLine("*#*#%+:*#+=####=#%%%#%%*.::.   ...:-.*%%%*-%###+%%%%==--%%%%:#%%*%%+.####=.##**##.=%%#*.#@@@@%%%%%%%%%%%%%%%%%%%%%%%%##**+++**++======+++++======++++*+++==++++++++=++***######**#=- ++=*@%###+=*###%%@*+@@@@@@#%@@@%@@@**@@@@@*%@@@%%@%=*@@%@@*+%@@%%@%+ -+=+*:+%@@@@@++@@@@@*#@@@%@@#*@@@%#@@@*@#%%+");
            Console.WriteLine("#%*==+*#-*%%%#=+######%=*%%%=*%###*:::... .-+**:*%%#-+.*###+.####%%=-%%#%=-%%*#%+.#%%#= %@@@@@%%@@%%%%%%%%%%%@%%%@%%%%##*++++++++*+*++==---===========--==-=-----==++*+********+++*= :**@@@@@@%#@@@%%@@*+%%%%%+=#%%####+:+####*++++++***-+@@%@@#+%%@%%%@#+%%%%%:=#*+**+.+**%%##@@@@@@@#%@@@#%%#%#@@@#*");
            Console.WriteLine(":  --+*+=%%%%%=*%%%###+=**#+=####%*-%#%%+-*+---.--=. =:###%+-%%##%%--%##*.=++===  ++**-.@@@@@@%%%%%%%%%%%%@%%@%%%%%%%%###*++++++++++**++++==================-=--======+++++*+++++++*.-#@@%%@%%**@@@%@@@+*@@@@@*+@@%%@%@*=%@%@@%#%@@%%@@#=+##***-=%%@%@@@**@@@@@++%%#%%#=@@@@%*#%%%#%%*+%%%%#@@@@%@@@##");
            Console.WriteLine("*=%#+++.:--+=-.+*###%%+#%%%=######-***##:*%##%++@%%+---###*..==--== .++++.*###%%:=%%#%-=@@@@@@%%@%@@%%%%@%@%%%%%%%%@%%%###*++++++++++++++++++++++=====+=========---====++++++++++++#:+@@%@@%@@++@%%#%@#+%%%%%%*#%@%%%@%++%%%%@#*%%%%%@@+=%@@@@%*%@%###**:+%%%@@+#@%%%%#=@@@@#*@@@@@@%#%@@@%#@@@@%@@@%*");
            Console.WriteLine("*#%##%%=#%%%@+-+-::::-.+%%%+%%%%%%+%%%#==**+*#=+%%%**.:*##*.+##*#%*.*###-:@%##%%:=%%%%-*@@@@@@%%%@%%%%%%@@%%%%%%@@%%%%%%%###**++++++=+++=++++++=++++++++++++++==------====--=+***+#%*%@@@#*#%**%@@@@@@##@@@@@%#%@%@@@@@*#@@@%@##%@%%%@@+=%%%@@**@@@%@@@#*@@@%#+-****##%:%%%@*#@@@@@@#%@@@@#@@%@#@@@@#=");
            Console.WriteLine("=#%#%%%+#%%%%+*%%##%%*:=--- :--=+*+%@%@=#%##%%*#%%%*--*####:*##*#%+:#%#%==%%##%#:*%%#*.=@@@@@@@@%@%%%%%%%%%@%%%%%%%@%%%%%%%######***+++==+=+++++++++++++**++=+=+++=-::-----=+****%##%@++@%%@@#%@@@%%%%#*%%#%%#+#%####%*=*##%#%=+#%%@@@@+%@%@@%*%@@@%@%%*#@@@@@##@@@@@@%-***#-+%%#%%%*@@@@#@@@@@@@@@@%*");
            Console.WriteLine(" -=+#%%+%%%%%=#%%##%%=+%%%%=#%###*::-+=:=**#%%##%%%#+-*%%%%-*%%#%%=:*#*+: ++=-=+ :###%+=@@@@@@@@%@@@@@%%%%%%%@@%%@@@@@%%%%%%%%####*******+++++***++++++++*****+===+++++++*******+*%@@@-+@%%%%+=%%@%@@@##@@@@@%#@@@@@@@@#%@@@@@#@@%%%%#+-*###%+*@@@@@@@##@@@@@%*%@@@@@@#+@@@@#*@@%@@#%@@@%#@@@@@%@@@@##");
            Console.WriteLine("+*+==-. ---=-:*#%%%%*-%#%%%-%%%#%%+%%%%**#*+==.:-==+-:-**++.:++=+*+.*##%#=%%%%%@*=%%%%#=#@@@@@@@@@%%%@%%@%%%@@%@%@@%@%%%%%%%%%#####***********+*+*++++++++++++*++++++********+++*++*+*:=%%@@@##@@@%@@@#*@@@@@%*@@@@@@@%#@@@@@@%@@@@@@@#*@@%%%+=%%%%%%*+%%%%%@#%@@@@@@@*#@@@@**@%%%@*#@@@#@@@@@@@@@@#+%");
            Console.WriteLine("%%%%%%#*%@#*-:--:::- -*##%+=%%##%%+#%%%**%%%%%**%%#+:-=%%%%*=@%%%%%=*@%%@++@%%%%%=*%%%%*+@@@@@@@@@%@@@@@@%%%%%@@@@%%@%@%%@@@@@%%###************+***++++====-=++=++++***#***++=+*@%%%@%=*@%###==**%***#--#***#=-#*****#-:*####*+##%%%@@%%@@@@@+=%%%@@@*%@@@@@##%%%#%%@##@@@@@*%@@%@@*%@@%#@%@@%@@@@@#%@");
            Console.WriteLine("####%%**%%%%+*%%#%%*:---:: ::-=*##=%%%%**%%%%%**%%%%+*=%%%%%=%%%%%%#-#%%%#=%%%%%@%+#@%@@#+%@@@@@@@@@@@@@@@@@@@@%@@@@@@@@%%@@@@@@@@%##*****+*****++++*++++==---====++*****++++**%%%%%%#=#@@%@%+*%@@%@@@++@@@@@++@@@%@@@*+@@@@@#*@@@%@@%**%%%@@#*%%%%@@*#@@@@##@@@@@@@%%@@%%%*+%%##%%-*%#%*@@@@%@@@@%#@@");
            Console.WriteLine("%%%%%%*#%###=*%%#%%*=%%%%*+%%*=:-  :::- -#%%@%**@%%%**=+%%%%*+%%%%%@++%%%@#*@@@%@@#=+##**+-%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@%#*##****+***++++++++++=====+++***++++*#+=#%%%%%%*-*%####+#@%%%%%%=+%%%%%-=%%%#%%@-=@%%%%+*@@@%@@@#%@@@@@#****++++ +**#**%%%%@@#%@@@@@%%@@@%@@%*%@@@*@@@@%@@@@*@@@");
            Console.WriteLine("%@@@@@##%%%%+%%#*##++%%%%++%%#%%%-*%##+:--::-- .-=*##*#+%%%@%+#@@%%%%--#***=-*%%%%@%*#@@@@%+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@%#*##******++++=+====-==+===++*#%#=:#%%%%@@*=%%%%@#+%@%%%%@%-#%%%%*-#%%%#%@%:=@%%%@+*@%%%@@@**@%%%@##@@@@@@@+=%%%@+#@%@@%+%@@@@#%@%%%@@@%#@@@@*%@@@%@@@%*%@@");
            Console.WriteLine("+#%%%%@@#@@@@%%@@@@@%%%%%*#%%#%%#*%%%%**%%%@@%**#**+*=*+=*****:####%%%+#@@@@#*@%%%@@%*#@@@@@#+@@@@@@@@@@@@@@@@@@@@@@@@@@@@#%@@@%*#@@%%@%#%@@@%@@%###*****++++++===++*+*#####+=###**+*. ++++*-.*##*###. +++++. +++=+++- =***#*-+###*%%%+*@@@@@**@@@%@@@#+%%%%#=%%%%@#*@@@@*@@@@@@@#%%%%%#+%%%@@@@@%%@@#");
            Console.WriteLine("+#%%%%%@+%%%%**##*##*=####*=***++=:=+++--+++*##+%@%@@%#%*#@%@%#*%%%%@@%*#@@@@%#%@@@%%%*=*#%%%%*#@@@@@@@@@@@@@@@@@@%@%%%%%++%@%@@+#@@@@@@*#@@@@%%@%%@@%%@@%#*+*******##%%%%%%==%%%#%%@--%%%%@==%%%*%%#:*%%%%#-+%%%#%%%==%%%%%*=#@%%###*.-+**#%=+@@@%@@@**@@@@%=#@%%@@+#@@@##@@%@@*%@@@@@%@@@@@@%@@%@@@#");
            Console.WriteLine(" .--::-- ---= :-+--=:.=++*-+%%%%%+*%%%%+%%%%%@@##@@@@%*#%*#@%@@*#@@@%@@%**%#*##=*%@@@@@@##@@@@@%##@@@@@@@@%@%#*-@@*@@%@@*=%@@@@#+%%%#%@%=%@@@@##@@@@@@%%@@@@*#@@%@@%+@@%%%%%-=%%%#%%@:=%%%%@=+@%%%%%+-#%%%%%=#@%%%%@%=+@%%%@+=%%%%%%@#-#@@@@%-=#++++*+:+%%@@%+%@@%@@**@@@%+@@@@@##@@@@#%@@@@@@%@@%@@%#");
            Console.WriteLine("**%@%%%#+@%%%+#%%#%%+*%%%%=*%%%%%#*%%%%#*%%####%*%%@@@%*@%##@%##=-*##%%@@%#@@@@@%#%@@%%%@%#%@@@@%#***%@%#+%@%@@#%*-##**#--*+**=-%@@%@@@*+@%%@@*+%%%%%%#*@@@@@%@@@@@*:#*+++*- .==-==+=:#%@@@%+#@@%%@%--%%@%@#*@@@@@@@%*#@@@@@+*@@%%@@@+=@@@@@*+%@@%%%@*=@@@@%*+%##*##=:#*#*:+#**#*-#%@@#%@@@@@%%@@###=*");
            Console.WriteLine("#+%%#%%%=%%%%+*%%#%%*+####+*%%%%@@%%@@%@##@%%%@@%#%@@%%#+##+#%%%@%#%@@@@@@%*#@@@@@%#@@@@%%%%%##@@@@@%%@%%#%@*#*#@@%#@@@@#*@%@%=*%%##%#=:=**#%#+@%%%@@@+*@@@@@*#@@%@@*@@@@@@=-@%%#%%%=-%%%##=.*##*#%%==%@%%@*%@@%%@@@+=%####=:*++**##*=#@@@@@*#@@@%@@@+*@%%@@**@@@@@@+#@@@%*%@@@@%+%@%@**%%%@@%@@@%@%#@");
            Console.WriteLine("*=#%##%%+%%%%#*%@%%@@%%@%@@%%@@@@@%#*%###+=******=-+***#+*@@##@@@@@##%@@@@@@%#%@%%%%##%@@@@@@@%%##%%%%%%%%%*#@@%@*%@%%@@@#@@@@*#%%#%%#-#%%%@#=*%##****:+%%@@@+%@@@@@##@@@@%--@%%#%%%-=@%%%%+=%%@#@%@==@%%@%+%@@@@@@%#%@@@@@*#@@@@@@@%%@@%@%#*####%%@%*%@@@@%*@@@@@@%#@@@@%%@@@@@##@@@@%@@@@@%@@@@@@#@@");
            Console.WriteLine("@%%@@%@@@#@@@@%#%%%#%#*=***+--=++++*=+#*##=*###%%@%%@@%%%##%@@#%@@@@%##%%%%%%@%#@@@@@@%%##%%@@@@@%%%%%*@@@+#@%%@%+%@@@#@%%##@@##@@%@@+=%%%%@+-@%%%%%@*=@%%##-:####%%%*@@@@%=#@%%#%%%-+%%%%%+=%%%#%%@-=%%%%*-%%@%@@@#*@@@@@%#@@@@@@%%@@@@@%@@@@@@@@%@@@@@%%#*%%%%%%%@@@%@@@@@%@@@@@@@@@@@@@@@@@@@@@@%@@");
            Console.WriteLine("**+=****##+#####+##%#%%##@@@@*%@@%%@%*%%%%**%@%%@%%#%%@@%%%%#@%#*%@@@@@#%@@@@@@@%#*#%@@@@@@@%%#*%@@%@*=%@##@%@@%=%@@%+%@%%@#%@@%##***+:*#*#%-*%%%%%%*-%@%%@#+#@@@%@%#=*#%%#+#@%%%@%#=#@%%%%+*%@%%@@@-*@%%%*=%@@%@@@**@@@@@##@@@%@%*#@@@%#*%%%%%%%##%@@@@%@@@@@@@@*%@@@@#@@@@@%*%@@%@@@@%@@@@@@@@@@@%@@");
            Console.WriteLine("%@@%#@%%%%%#%%%%%*%%%%%%*%%%@%+%%%%%%*##@@@@%@@@@@@@@%#@@@@@#*+%@%#@@@@@@#*#%%@@@@@@%@@@@#%@#*%#@%*%@@#@@*+#*%%=@%@@+@@%%%@=%@%@*%@@@@#@@@@%=#*+==++-=@@%@%*=#%@%%@@%*%@@@*+##***#++.++**##=*%%***#=.++*++: =+==+=*.:#*#%%++%%%#@@#*@@@@@##@@@@@@@#@@@@@%@@@@@@@%#@@@%#+=#%%@@%*%@%@@@@%@@@@@@@@@@*#*#");
            Console.WriteLine("%%%%*%%%#%%**%%%%=#%#%%%#%@@@@@%@#%@@@%+%%%@%#%@@@@@@@%#%#%%@@@%%%@%##@@@@@@%#%@@@@@@@%*%@#%*@@##%*#@@+%@@#@@@*=###=*@@%@@+*%@@%+#%%%@%*@@@%*@@@%@@%++#*+=+.:#%%%%@@*+@@@@##%@@%%@%#+%%@@@%=#@@%%@@++@@@%%+-%%%#%%%--%%%@@*+@@@%@@@-#@@@@#=#@@%@@@#+@@@@@%@@@@@@#%@@@@@%@@@@@@@*#@@@#@@@@@@@@@@@@@%%@@");
            Console.WriteLine("%%%%##%%%%@@@@@@%@@@@@%@@%%%%%@@*#@%%%%##%%%@%##%@%#**##%%%@@@%%%#*%@@%%%@@@%%%@@%%@##*%@*%%#%%#@%@%++#%@%+@@@@*@@@*#%###=-#%%@+#@@%@@#+@@@%+@%%%%%%+*@@@@@++%%#+++*:+%@@@%#@@@@@@@#*@@%%%#*%%@%%@@**@@@@@+=%%%#%%%=-%%%%@+-%@@%@@@+=%%%%#-+###**#+:****#--#**###=#%%%#*@@@@@@%*#%%%*-###%##@@@%@@@%@@");
            Console.WriteLine("%%@@%@@@@@%@@@@@@%%%%##*%%@**@%%#+%%%%@@##@@@%%=-+*##@@@@@%###%#%%%%@@@@@@%%%%%%@@@@%##%+%@%%@#%%@**@@@%+*##%@%+@@@*%@@@@+%@@@*=%#**#%=%@@@%#@@@%@@%+*%%%%%*@@@%%@@#=%@%%#++##%#%%@**@@@@@##@@@@@@@*#@@%%%*=#**++++. ==+++: =++===*::####*:*%@%@@@#+@@@@@**@@@@@@*=@@@%*+######-=%%@@+%@@@@%@@@@%%%*%%");
            Console.WriteLine("@@@@@%%@@@@#@%%###+#@#*%%%%%*%%%@%*%@@%%#=:++++#%%@@@@@%*#%%%@@@@@%%%@%%%@@@@@@@@@@@*@%#@#*#@#%%%%*@%%*%@@@@%+=#%%%+%@@@@*@@@@+#@@%@@*=##*#-+#%%%@@%*@@@@@#+@%%%%%@++@@@@@##@@@@@@@++###%#++%%%%@@@*%@@%@@*#@@@%@@%+=%%%%%+-%%%#%%%=-%%%%%-+@%%@@@**@@@@%*#@@%@@@*=@@@%%=#@%%@@#+@@@@#@@@@%%@@@@@@@#@@");
            Console.WriteLine("%@@@@@%##*#*=%@@@*%%%#+%%%%@%#%@@%+.=+==+#%#%@@@@@%#++@@%*#@@@@@@#%@@%%%@@@@@@@@@@@@#+%#%%#%##@@@*#%@#@@%%@**@@%@*+**+*%+*@@@#+@@%%@@**@@@%*#@@#***::%%%@@++@@@%@@@++@@@@@##@@@%@@@*@@@@@@#@@@@@@@%#%@@@@@##@@@@@@@**@@%%%*=#%%####+:#%##%+-%%#%%#*@@@@@%#@@@@@@@*%@@@@%*%@@%@@#%@@@@@@@@@@@@@@@@@@*@@");
            Console.WriteLine("%+#*****#@@@###%%*#@%@#*%@%%*=:+==**#@@@@@@@@%**##@%%%%@@@@@%%%*%@@@@@@@@@@@@@@@@@@@*%%+#%%@##%@*@@@%#@@@@*%@@@#+@@@%@@++%#**:+*#%@@%=@@@@%+@@@%@@@+*@@%##.:**+#%@@**@@@@@*@@@%%@@#*@@@@@%*%@@@@@@%*%@@@@@##@@@@@@@*#@@@@@**@@@%%%@+=#@%%%*=%%%%@#=%@@@%*@@@@@@%*#@@@@@#%@@@%@@@%@@@@@@@@@@@@@@@@@@*@@");
            Console.WriteLine("##*%@%@@*%%#*%%%%%+%%%*:-++=*%#*@@@@@@@%%%%#%@%%#**%@@@@@@@%#%@%%%@@@@@@@@@@@@@@@@@@*%*%##%@#@%*%@@%#@%#%%*@@@%#@@%%@@+*@%@@+*@@%%#*.-**%%*%@@@@@@%+%@@%%%+#@@%###*:-#%@%**%%@%@@@**@@@@@#*@@@@@@@%*%@%%%%+*%%%%%%%**%%%%%*+%%%##%%+:*#***=.=+++**.+#%%+#@@@@@@#%@@@@@#%@@@@#@@@#@@@@@%@@@@@@@@@@@%%@%");
            Console.WriteLine("@@*#%#%##@@@##@%#*=:++*#+%@@%@@@@@%%#%%%#%%**#%%@@@%#%@@%#%@@@@@@%%@@@@@@@@@@@@@@@@@#+@##%###@@%%%%%@@@@%#*%%@##@@@@@%#@%%@*+@@%%@@*+@@@%*=%####%%**@@@@@#=#%%%%@@%++@@@%==%##***##@#*#**--**#**##+-#%%%%%**@@@@@@@##@@@@@%#@@@@@@@%*%@@@@@+#%@#%%#-%%%*+@@%@@##@@@@%%@@@@@#%%%@#%@@@@@%@@@@@@@@%#-#**");
            Console.WriteLine("%%#*@%%%##%%#+=*##@@%%@@@#%@@@@##%%#*+%##%@@@%#%@@@@@#+*%@@@@%@@@@@@@@@@@@@@@@@@@@@@%##%%%%%##@%@%*%%@@#*%#@@@%#%%%%@#@@@@@#@@%%%%#=@@@@@*#@@@%@@%=+**+##=*@%@%%@@*-#%@@@=+@%%#@@@@@%@@@%+-%%@%%%@#=#%%@%%+*@@@%@@@**@@@@@%#@@@@@@@%*%@@@@@**@@%%%%+=%%@++%%%%**%###=%@%@@@#@@@@%%@@@@@%@@@@@@@@@#*@@@");
            Console.WriteLine("#%@%#@%***=*%@@#@@%%@@%%@@@%++%+*#*+#@*@@@@%%@@%%%##%@@@%#%@@@%@@@@@@@@@@@@@@@@@@@@@%%+%@+%%%@%#%%%@%%*#@@@@@@%%@@@@%*%#%%##@@@@@@+%@@%@*=@@%%@@@+*@@@@@##@##+++*+-#@@@@@=#@@%%@%%%%%@@@@%=%%@%%%@#-*%@%%%++@@@%@@%+*@@@@@%*@@@@@@@@#@@@@@@##@@%##*+ :++#*-%%%%=%@@%*@@@@@@#@@@@#@@@@@@@@@@@@@@@@#%@@@");
            Console.ReadLine();
            Console.WriteLine("Acii too Sorry but you win i guess");
            Console.ReadLine();
            Environment.Exit(0);
        }


        static void fight()
        {
            string option;
            int hit;
            Health = 100+armour;
            int charge = 0;
            Random random = new Random();
            do
            {
                do
                {
                    Console.WriteLine($"You have {Health} HP and {energy} Energy.                                                          {EnemyName} has {EnemyHealth} HP");//Change to name from list
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Choose your move!: \n1: Strong Attack \n2: Medium Attack \n3: Low Attack \n4: Charge Attack \n5: Gain Energy");

                    option = Convert.ToString(Console.ReadLine().ToLower());
                    hit = random.Next(101);
                    Console.Clear();
                    if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5")
                    {
                        Console.WriteLine("Please enter 1,2,3,4 or 5");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }while(option != "1" && option != "2" && option != "3" && option != "4" && option != "5");

                switch (option)
                {
                    case "1": if (energy >= 40) { energy -= 40; Damage = random.Next(30, 41); if (hit > 84) EnemyHealth -= Damage + weapon; else Console.WriteLine("You missed"); } else Console.WriteLine("you don't have enough energy for the Strong Attack"); break;
                    case "2": if (energy >= 20) { energy -= 20; Damage = random.Next(19, 32); if (hit > 50) EnemyHealth -= Damage + weapon; else Console.WriteLine("You missed"); } else Console.WriteLine("you don't have enough energy for the Medium Attack"); break;
                    case "3": if (energy >= 10) { energy -= 10; Damage = random.Next(9, 22); ; if (hit > 25) EnemyHealth -= Damage + weapon; else Console.WriteLine("You missed"); } else Console.WriteLine("you don't have enough energy for the Low Attack"); break;
                    case "4": if (charge == 3) { Damage = random.Next(50, 80); EnemyHealth -= Damage + weapon; charge = 0; } else charge++; break;
                    case "5": int energyGained = random.Next(1, 50); energy = Math.Min(100, energy + energyGained); break;
                }

                if (EnemyHealth > 0) enemyAttack(); // Enemy attacks only if it's still alive
                Console.WriteLine("\n\n");
            } while (Health > 0 && EnemyHealth > 0);

            if (Health <= 0)
            {
                Console.WriteLine("You have been defeated. Game Over.");
                Console.ReadLine();
                if (difficulty > 1)
                {
                    hallway();
                }
                else
                {
                    Start();
                }

            }
            else if (EnemyHealth <= 0)
            {
                Console.WriteLine("You have defeated the enemy!");
                // Implement logic to reward the player or move to the next part of the game

                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                difficulty++;
                Console.Clear();
                Console.WriteLine("You've been kicked out into the hallway"); //Added here since you get kicked out here everytime to kill a boss

                callroom();

            }
        }

        static void enemyAttack()
        {
            Random random = new Random();
            int hit = random.Next(101);
            int enemyChoice = random.Next(1, 5);

            switch (enemyChoice)
            {
                case 1: Damage = 30; if (hit > 75) Health -= Damage; else Console.WriteLine("Enemy missed"); break;//replace enemy name with one from a list
                case 2: Damage = 20; if (hit > 50) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 3: Damage = 10; if (hit > 25) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 4: Damage = 5; if (hit > 1) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
            }
        }
    }
}