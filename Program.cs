using System.Threading;
using System;

namespace PA4_laineykersey
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay();
        }
        static void GamePlay()
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom, press any key to continue");
            Console.ReadKey();
            System.Console.WriteLine("Let's Play!");
            FirstMenu();
        }
        
        public static string FirstPlayer()
        {
            System.Console.WriteLine("Player 1, please type your name:");
            return Console.ReadLine();
        }
        public static string SecondPlayer()
        {
            System.Console.WriteLine("Player 2, please type your name:");
            return Console.ReadLine();
        }
        public static int FPlayerChar()
        {
            System.Console.WriteLine("Player 1, please enter the corresponding number to the character you'd like to play as:");
            System.Console.WriteLine("1. Jack Sparrow");
            System.Console.WriteLine("2. Will Turner");
            System.Console.WriteLine("3. Davy Jones");
            return int.Parse(Console.ReadLine());
        }
        static int SPlayerChar()
        {
            System.Console.WriteLine("Player 2, please enter the corresponding number to the character you'd like to play as:");
            System.Console.WriteLine("1. Jack Sparrow");
            System.Console.WriteLine("2. Will Turner");
            System.Console.WriteLine("3. Davy Jones");
            return int.Parse(Console.ReadLine());
        }


        static void FirstMenu() 
        {
            Character first = new Character();
            string firstName = FirstPlayer();
            first.PlayerName = firstName;
          
                int playerChoice = FPlayerChar();
                
                switch(playerChoice)
                {
                    case 1:
                        System.Console.WriteLine(firstName + ", you are playing as Jack Sparrow.");
                        first = new JackSparrow(){PlayerName = first.PlayerName, CharName = "Jack Sparrow", MaxPower = first.RandMax(), Health = 100, AttackStrength = first.RandAttackStrength(), DefensePower = first.RandDefensePower()};;
                        break;

                    case 2:
                        System.Console.WriteLine(firstName + ", you are playing as Will Turner.");
                        first = new WillTurner(){PlayerName = first.PlayerName, CharName = "Will Turner", MaxPower = first.RandMax(), Health = 100, AttackStrength = first.RandAttackStrength(), DefensePower = first.RandDefensePower()};;
                        break;

                    case 3:
                        System.Console.WriteLine(firstName + ", you are playing as Davy Jones.");
                        first = new DavyJones(){PlayerName = first.PlayerName, CharName = "Davy Jones", MaxPower = first.RandMax(), Health = 100, AttackStrength = first.RandAttackStrength(), DefensePower = first.RandDefensePower()};;
                        break;

                    default:
                        System.Console.WriteLine("That player has already been chosen, please choose again");
                        break;
                }
                SecondMenu(first);
        }
        static void SecondMenu(Character first) 
        {
            Character second = new Character();
            string secondName = SecondPlayer();
            second.PlayerName = secondName;
            
            int playerChoice = SPlayerChar();
                
                switch(playerChoice)
                {
                    case 1:
                        System.Console.WriteLine(secondName + ", you are playing as Jack Sparrow.");
                        second = new JackSparrow(){PlayerName = second.PlayerName, CharName = "Jack Sparrow", MaxPower = second.RandMax(), Health = 100, AttackStrength = second.RandAttackStrength(), DefensePower = second.RandDefensePower()};;
                        break;

                    case 2:
                        System.Console.WriteLine(secondName + ", you are playing as Will Turner.");
                        second = new WillTurner(){PlayerName = second.PlayerName, CharName = "Will Turner", MaxPower = second.RandMax(), Health = 100, AttackStrength = second.RandAttackStrength(), DefensePower = second.RandDefensePower()};;
                        break;

                    case 3:
                        System.Console.WriteLine(secondName + ", you are playing as Davy Jones.");
                        second = new DavyJones(){PlayerName = second.PlayerName, CharName = "Davy Jones", MaxPower = second.RandMax(), Health = 100, AttackStrength = second.RandAttackStrength(), DefensePower = second.RandDefensePower()};;
                        break;

                    default:
                        System.Console.WriteLine("That character has already been chosen, please choose again");
                        break;
                }
                Turns(first, second);

            
        }
        static void Turns(Character first, Character second)
        {
            System.Console.WriteLine("The computer will decide randomly who goes first");
            int number = RandTurn();
            if(number == 1)
            {
                System.Console.WriteLine($"{first.PlayerName} as {first.CharName} will go first");
                while(first.Health > 0 && second.Health > 0)
                {
                    FirstGame(first, second);
                    SecondGame(first, second);
                    GameWin(first, second);
                }
            }
            else
            {
                System.Console.WriteLine($"{second.PlayerName} as {second.CharName} will go first");

                while(first.Health > 0 && second.Health > 0)
                {
                    FirstGame(first, second);
                    SecondGame(first, second);
                    GameWin(first, second);
                }
            }
            
            
        }
        static int RandTurn()
        {
            Random random = new Random();
            int rand = random.Next(1,2);
            int r = rand;
            return r;
        }
        static void FirstGame(Character first, Character second)
        {
            if(first.Health >= 0 && second.Health >= 0)
            {  
                first.attackBehavior.Attack();
                double typeBonus = 1;
                if((first.CharName == "Jack Sparrow" && second.CharName == "Will Turner") || (first.CharName == "Will Turner" && second.CharName == "Davy Jones") || (first.CharName == "Davy Jones" && second.CharName == "Jack Sparrow"))
                {
                    typeBonus = 1.2;
                    double damage = first.AttackStrength - second.DefensePower * typeBonus;
                    if(first.Health > 0 && second.Health > 0)
                    {
                        if(damage >= 0)
                        {
                            first.Health -= damage;
                            System.Console.WriteLine("Damage done: " + damage);
                        }
                        else
                        {
                            first.defendBehavior.Defend();
                        }
                    } 
                }
                else
                {
                    double damage = first.AttackStrength - second.DefensePower * typeBonus;
                    if(first.Health > 0 && second.Health > 0)
                    {
                        if(damage > 0)
                        {
                            first.Health -= damage;
                            System.Console.WriteLine("Damage done: " + damage);
                        }
                        else
                        {
                            first.defendBehavior.Defend();
                        }
                    } 
                }
                System.Console.WriteLine("Here are the stats after this round:");
                first.Stats(); 
                second.Stats();
                System.Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }
        }
        static void SecondGame(Character first, Character second)
        {
            if(first.Health >= 0 && second.Health >= 0)
            { 
                second.attackBehavior.Attack();
                double typeBonus = 1;
                if((second.CharName == "Jack Sparrow" && first.CharName == "Will Turner") || (second.CharName == "Will Turner" && first.CharName == "Davy Jones") || (second.CharName == "Davy Jones" && first.CharName == "Jack Sparrow"))
                {
                    typeBonus = 1.2;
                    double damage = second.AttackStrength - first.DefensePower * typeBonus;
                    if(first.Health > 0 && second.Health > 0)
                    {
                        if(damage > 0)
                        {
                            second.Health -= damage;
                            System.Console.WriteLine("Damage: " + damage);
                        }
                        else
                        {
                            second.defendBehavior.Defend();
                        }
                    } 
                }
                else
                {
                    double damage = second.AttackStrength - first.DefensePower * typeBonus;
                    if(first.Health > 0 && second.Health > 0)
                    {
                        if(damage > 0)
                        {
                            second.Health -= damage;
                            System.Console.WriteLine("Damage: " + damage);
                        }
                        else
                        {
                            second.defendBehavior.Defend();
                        }
                    } 
                }
                System.Console.WriteLine("Here are the stats after this round:");
                first.Stats();
                second.Stats();
                System.Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
        static void GameWin(Character first, Character second) 
        {
            if(first.Health <=0)
            {
                System.Console.WriteLine($"{first.PlayerName} as {first.CharName} is the winner! Better luck next time {second.PlayerName}.");
            }
            else if(second.Health <=0)
            {
                System.Console.WriteLine($"{second.PlayerName} as {second.CharName} is the winner! Better luck next time {first.PlayerName}.");
            }
        }

    }
}
        