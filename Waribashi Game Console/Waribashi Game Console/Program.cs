using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waribashi_Game_Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            String choice;
            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to Waribashi Game!");
            Console.WriteLine("******************************** \n");
            Console.WriteLine("Press 1 and Enter to Play.");
            Console.WriteLine("Press 2 and Enter to See Instruction.");
            Console.WriteLine("Press 3 and Enter to Exit.");
            Console.Write("Enter your Choice: ");
            //Console.WriteLine("{0}", choice);
            
            choice = Console.ReadLine();
            if (choice == "1")
            {
                PlayGame();
            }
            else if (choice == "2")
            {
                Instuctions();
            }
            else if (choice == "3")
            {
                ExitApplication();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You entered Wrong Character. Please Try Again!\n\n");
                Main(args);
            }
           
        }

        public static void Instuctions()
        {
            Console.Clear();
            String choice;
            Console.WriteLine("********************************");
            Console.WriteLine("Waribashi Game Rules!");
            Console.WriteLine("******************************** \n");
            Console.WriteLine("\n\n1. Each player uses both hands to play the game. The finger/s extended on a hand show/s the number of points the player has. A hand with all fingers extended is considered as dead hand. \n\n2. Both players start with each hand having one point (one finger extended on each hand). \n\n3. Players take alternate turns to tap one of their hands against the opponent's hands that is not dead. \n\n4.The number of points on the tapping hand is added to the number on the tapped hand, and the player with the tapped hand should extend their digits to show the new score. The tapping hand remains unchanged. \n\n5. A player may tap their own hand to transfer points from one hand to the other. For example, if a player had three points on his or her right hand and one on his or her left, the player could rearrange them to have two on each hand. A dead hand is treated as having no points, for this purpose, which allows a player to bring a dead hand back into play by transferring points to it. \n\n6. The first player having both hands dead loses the game.");
            Console.WriteLine("\n\n\nPress 1 and Enter to Play.");
            Console.WriteLine("Press 3 and Enter to Exit.");
            Console.Write("Enter your Choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                PlayGame();
            }
            else if (choice == "3")
            {
                ExitApplication();
            }
        }

        public static void ExitApplication()
        {
            Environment.Exit(0);
            Console.Read();
        }

        public static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("Waribashi Game!");
            Console.WriteLine("******************************** \n");
            int L1, L2, R1, R2;            
            L1 = 1;
            L2 = 1;
            R1 = 1;
            R2 = 1;
            Player1Turn(L1, L2, R1, R2);
        }
        
        public static void Player1Turn(int L1, int L2, int R1, int R2)
        {
            String choice;
            Console.WriteLine("\nPlayer 1 Left Hand (L1): " + L1);
            Console.WriteLine("Player 1 Right Hand (R1): " + R1);
            Console.WriteLine("Player 2 Left Hand (L2): " + L2);
            Console.WriteLine("Player 2 Right Hand (R2): " + R2);
            if ((L1 < 5) && (L2 < 5) && (R1 < 5) && (R2 < 5))
            {
                Player1TurnNormal(L1, L2, R1, R2);                
            }
            else if (((L1 >= 5) && (R1 >= 5)) || ((L1 == 0) && (R1 == 0)) || ((L1 == 0) && (R1 >= 5)) || ((L1 >= 5) && (R1 == 0)))
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Player 2 Wins!");
                Console.WriteLine("******************************** \n");
                Console.WriteLine("Press 1 and Enter to Play.");
                Console.WriteLine("Press 2 and Enter to See Instruction.");
                Console.WriteLine("Press 3 and Enter to Exit.");
                Console.Write("Enter your Choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    PlayGame();
                }
                else if (choice == "2")
                {
                    Instuctions();
                }
                else if (choice == "3")
                {
                    ExitApplication();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered Wrong Character. Please Try Again!\n\n");
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else if (((L2 >= 5) && (R2 >= 5)) || ((L2 == 0) && (R2 == 0)) || ((L2 >= 5) && (R2 == 0)) || ((L2 == 0) && (R2 >= 5)))
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Player 2 Wins!");
                Console.WriteLine("******************************** \n");
                Console.WriteLine("Press 1 and Enter to Play.");
                Console.WriteLine("Press 2 and Enter to See Instruction.");
                Console.WriteLine("Press 3 and Enter to Exit.");
                Console.Write("Enter your Choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    PlayGame();
                }
                else if (choice == "2")
                {
                    Instuctions();
                }
                else if (choice == "3")
                {
                    ExitApplication();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered Wrong Character. Please Try Again!\n\n");
                    Player1Turn(L1, L2, R1, R2);
                }

            }
            else if ((L1 >= 5) || (L2 >= 5) || (R1 >= 5) || (R2 >= 5))
            {
                if (L1 >= 5)
                {
                    L1 = 0;
                    Player1TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (L2 >= 5)
                {
                    L2 = 0;
                    Player1TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (R1 >= 5)
                {
                    R1 = 0;
                    Player1TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (R2 >= 5)
                {
                    R2 = 0;
                    Player1TurnWithDeadHand(L1, L2, R1, R2);
                }
            }
            Console.Read();
        }

        public static void Player1TurnNormal(int L1, int L2, int R1, int R2)
        {

            String Player1Hand, Player2Hand;
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("\n\nPlayer 1's Turn");
            Console.WriteLine("\nType L1 for Left Hand.");
            Console.WriteLine("Type R1 for Right Hand.");
            Console.Write("\nEnter Hand(Left/Right): ");
            Player1Hand = Console.ReadLine().ToLower();
            if (Player1Hand == "l1")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L2 for Left Hand of the other Player.");
                Console.WriteLine("Type R2 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player2Hand = Console.ReadLine().ToLower();
                if (Player2Hand == "l2")
                {
                    L2 = L2 + L1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else if (Player2Hand == "r2")
                {
                    R2 = R2 + L1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player1Turn(L1, L2, R1, R2);
                }

            }
            else if (Player1Hand == "r1")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L2 for Left Hand of the other Player.");
                Console.WriteLine("Type R2 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player2Hand = Console.ReadLine().ToLower();
                if (Player2Hand == "l2")
                {
                    L2 = L2 + R1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else if (Player2Hand == "r2")
                {
                    R2 = R2 + R1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else
            {
                Console.WriteLine("\n\n********************************");
                Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                Player1Turn(L1, L2, R1, R2);
            }
            Console.Read();
        }

        public static void Player1TurnWithDeadHand(int L1, int L2, int R1, int R2)
        {
            String Player1Hand, Player2Hand;
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("\n\nPlayer 1's Turn");
            Console.WriteLine("\nType L1 for Left Hand.");
            Console.WriteLine("Type R1 for Right Hand.");
            Console.WriteLine("Type T for Transfer of Points.");
            Console.Write("\nEnter Hand(Left/Right) or Transfer(T): ");
            Player1Hand = Console.ReadLine().ToLower();
            if (Player1Hand == "l1")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L2 for Left Hand of the other Player.");
                Console.WriteLine("Type R2 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player2Hand = Console.ReadLine().ToLower();
                if (Player2Hand == "l2")
                {
                    L2 = L2 + L1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else if (Player2Hand == "r2")
                {
                    R2 = R2 + L1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else if (Player1Hand == "r1")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L2 for Left Hand of the other Player.");
                Console.WriteLine("Type R2 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player2Hand = Console.ReadLine().ToLower();
                if (Player2Hand == "l2")
                {
                    L2 = L2 + R1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else if (Player2Hand == "r2")
                {
                    R2 = R2 + R1;
                    Player2Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else if (Player1Hand == "t")
            {
                if (((R1 == 0) && (L1 == 1)) || ((R1 == 1) && (L1 == 0)))
                {
                    Console.WriteLine("\nYou cannot transfer points because the value of your hand is only 1.");
                    Player1Turn(L1, L2, R1, R2);
                }
                else if (((R1 == 0) && (L1 > 1)) || ((R1 > 1) && (L1 == 0)))
                {
                    int val;
                    Console.Write("\nPlease enter the value of your Left Hand: ");
                    val = Convert.ToInt32(Console.ReadLine());
                    if (L1 == 0)
                    {
                        L1 = R1 - val;
                    }
                    else
                    {
                        R1 = L1 - val;
                    }
                    Player2Turn(L1, L2, R1, R2);
                }
            }
            else
            {
                Console.WriteLine("\n\n********************************");
                Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                Player1Turn(L1, L2, R1, R2);
            }
            
            Console.Read();
        }

        public static void Player2Turn(int L1, int L2, int R1, int R2)
        {
            String choice;
            Console.WriteLine("\nPlayer 1 Left Hand (L1): " + L1);
            Console.WriteLine("Player 1 Right Hand (R1): " + R1);
            Console.WriteLine("Player 2 Left Hand (L2): " + L2);
            Console.WriteLine("Player 2 Right Hand (R2): " + R2);
            if ((L1 < 5) && (L2 < 5) && (R1 < 5) && (R2 < 5))
            {
                 Player2TurnNormal(L1, L2, R1, R2);
            }
            else if (((L1 >= 5) && (R1 >= 5)) || ((L1 == 0) && (R1 == 0)) || ((L1 == 0) && (R1 >= 5)) || ((L1 >= 5) && (R1 == 0)))
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Player 2 Wins!");
                Console.WriteLine("******************************** \n");
                Console.WriteLine("Press 1 and Enter to Play.");
                Console.WriteLine("Press 2 and Enter to See Instruction.");
                Console.WriteLine("Press 3 and Enter to Exit.");
                Console.Write("Enter your Choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    PlayGame();
                }
                else if (choice == "2")
                {
                    Instuctions();
                }
                else if (choice == "3")
                {
                    ExitApplication();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered Wrong Character. Please Try Again!\n\n");
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else if (((L2 >= 5) && (R2 >= 5)) || ((L2 == 0) && (R2 == 0)) || ((L2 >= 5) && (R2 == 0)) || ((L2 == 0) && (R2 >= 5)))
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Player 2 Wins!");
                Console.WriteLine("******************************** \n");
                Console.WriteLine("Press 1 and Enter to Play.");
                Console.WriteLine("Press 2 and Enter to See Instruction.");
                Console.WriteLine("Press 3 and Enter to Exit.");
                Console.Write("Enter your Choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    PlayGame();
                }
                else if (choice == "2")
                {
                    Instuctions();
                }
                else if (choice == "3")
                {
                    ExitApplication();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered Wrong Character. Please Try Again!\n\n");
                    Player1Turn(L1, L2, R1, R2);
                }

            }
            else if ((L1 >= 5) || (L2 >= 5) || (R1 >= 5) || (R2 >= 5))
            {
                if (L1 >= 5)
                {                    
                    L1 = 0;
                    Player2TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (L2 >= 5)
                {
                    L2 = 0;
                    Player2TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (R1 >= 5)
                {
                    R1 = 0;
                    Player2TurnWithDeadHand(L1, L2, R1, R2);
                }
                else if (R2 >= 5)
                {
                    R2 = 0;
                    Player2TurnWithDeadHand(L1, L2, R1, R2);
                }                
            }
            Console.Read();
        }
        public static void Player2TurnNormal(int L1, int L2, int R1, int R2)
        {
            String Player1Hand, Player2Hand;
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("\n\nPlayer 2's Turn");
            Console.WriteLine("\nType L2 for Left Hand.");
            Console.WriteLine("Type R2 for Right Hand.");
            Console.Write("\nEnter Hand(Left/Right): ");
            Player2Hand = Console.ReadLine().ToLower();
            if (Player2Hand == "l2")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L1 for Left Hand of the other Player.");
                Console.WriteLine("Type R1 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player1Hand = Console.ReadLine().ToLower();
                if (Player1Hand == "l1")
                {
                    L1 = L1 + L2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else if (Player1Hand == "r1")
                {
                    R1 = R1 + L2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player2Turn(L1, L2, R1, R2);
                }
            }
            else if (Player2Hand == "r2")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L1 for Left Hand of the other Player.");
                Console.WriteLine("Type R1 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player1Hand = Console.ReadLine().ToLower();
                if (Player1Hand == "l1")
                {
                    L1 = L1 + R2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else if (Player1Hand == "r1")
                {
                    R1 = R1 + R2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player2Turn(L1, L2, R1, R2);
                }
            }
            else
            {
                Console.WriteLine("\n\n********************************");
                Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                Player2Turn(L1, L2, R1, R2);
            }
            
            Console.Read();
        }
       public static void Player2TurnWithDeadHand(int L1, int L2, int R1, int R2)
        {
            String Player1Hand, Player2Hand;
            Console.WriteLine("\n\n********************************");
            Console.WriteLine("\n\nPlayer 2's Turn");
            Console.WriteLine("\nType L2 for Left Hand.");
            Console.WriteLine("Type R2 for Right Hand.");
            Console.WriteLine("Type T for Transfer of Points.");
            Console.Write("\nEnter Hand(Left/Right) or Transfer(T): ");
            Player2Hand = Console.ReadLine().ToLower();
            if (Player2Hand == "l2")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L1 for Left Hand of the other Player.");
                Console.WriteLine("Type R1 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player1Hand = Console.ReadLine().ToLower();
                if (Player1Hand == "l1")
                {
                    L1 = L1 + L2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else if (Player1Hand == "r1")
                {
                    R1 = R1 + L2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player2Turn(L1, L2, R1, R2);
                }
            }
            else if (Player2Hand == "r2")
            {
                Console.WriteLine("\nWhere do you want to add?");
                Console.WriteLine("\nType L1 for Left Hand of the other Player.");
                Console.WriteLine("Type R1 for Right Hand of the other Player.");
                Console.Write("\nEnter Hand(Left/Right): ");
                Player1Hand = Console.ReadLine().ToLower();
                if (Player1Hand == "l1")
                {
                    L1 = L1 + R2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else if (Player2Hand == "r1")
                {
                    R1 = R1 + R2;
                    Player1Turn(L1, L2, R1, R2);
                }
                else
                {
                    Console.WriteLine("\n\n********************************");
                    Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                    Player2Turn(L1, L2, R1, R2);
                }
            }
            else if (Player2Hand == "t")
            {
                if (((R2 == 0) && (L2 == 1)) || ((R2 == 1) && (L2 == 0)))
                {
                    Console.WriteLine("\nYou cannot transfer points because the value of your hand is only 1.");
                    Player2Turn(L1, L2, R1, R2);
                }
                else if (((R2 == 0) && (L2 > 1)) || ((R2 > 1) && (L2 == 0)))
                {
                    int val;
                    Console.Write("\nPlease enter the value of your Left Hand: ");
                    val = Convert.ToInt32(Console.ReadLine());
                    if (L2 == 0)
                    {
                        L2 = R2 - val;
                    }
                    else
                    {
                        R2 = L2 - val;
                    }
                    Player1Turn(L1, L2, R1, R2);
                }
            }
            else
            {
                Console.WriteLine("\n\n********************************");
                Console.WriteLine("\n\nYou entered Wrong Character. Please Try Again!");
                Player2Turn(L1, L2, R1, R2);
            }            
            Console.Read();
        }       
    }
}
