using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeTest
{
    public static class GameLogic
    {
        //fields
        private static Character _humanPlayer;
        private static Character _aiPlayer;
        private static Background _background;
        private static StreamWriter _gameWriter;
        private static StreamReader _gameReader;
        private static string _filePath;
        


        
      
        //properties
        public static Character HumanPlayer { get { return _humanPlayer; } set { _humanPlayer = value; } }
        public static Character AIPlayer { get { return _aiPlayer; } set { _aiPlayer = value; } }
        public static Background Background { get { return _background; } set { _background = value; } }
        public static int Level { get; set; }
        

        //constructor
        static GameLogic()
        {
            _filePath = @"C:\Users\Joshua\source\repos\PracticeTest\PracticeTest\Model\save.txt";
            
            
        }



            
        //methods
        public static void CreateGame()
        {
            ResourceController.PlayMusic();
            //if stream writer is null create it
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Scientist v. The World!");
            if (File.Exists(_filePath) && (File.ReadAllLines(_filePath).Length == 3))
            {
                _gameReader = new StreamReader(_filePath);
                HumanPlayer = new Scientist(_gameReader.ReadLine(), _gameReader.ReadLine());
                Console.WriteLine("Welcome back {0}, {1}", HumanPlayer.Name, HumanPlayer.Description);
                Level = Convert.ToInt32(_gameReader.ReadLine());
                LoadGame();
            } else
            {
                try
                {
                    File.Delete(_filePath);
                    _gameWriter = new StreamWriter(_filePath, true);
                    Console.WriteLine("Enter your players name!");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your players description!");
                    string desc = Console.ReadLine();
                    HumanPlayer = new Scientist(name, desc);
                    Level = 1;
                    _gameWriter.WriteLine(name);
                    _gameWriter.WriteLine(desc);
                    _gameWriter.WriteLine(Level);
                    if (HumanPlayer != null)
                        Console.WriteLine("Successfully created player!");
                    _gameWriter.Close();
                    LoadGame();
                }
                finally
                {
                    if (_gameWriter != null)
                    {
                        _gameWriter.Close();
                    }
                } 
            }
            Console.ResetColor();
            MenuController.HandleState();
          
            
        }

        public static void AttackSequence()
        {
            if (((Scientist)HumanPlayer).PotionListNotEmpty())
            {
                Scientist s = ((Scientist)HumanPlayer);
                PotionType t = s.Potion.First().Type;
                s.Attack(AIPlayer, t);
                s.RemovePotionType(t);
            } else
            {
                HumanPlayer.Attack(AIPlayer);
                AIPlayer.Attack(HumanPlayer);

            }
                GameItems.RandomItem(AIPlayer);
                GameItems.RandomItem(HumanPlayer);
            if (HumanPlayer.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Oooh nooo!, you lost to", AIPlayer.Name);
                //prompt new menu here?
                LoadGame();
            } else if (AIPlayer.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Congratulations, you bet {0}", AIPlayer.Name);
                Level += 1;
                LoadGame();
                //change to end game
            } else
            {

            }
            MenuController.StartMenu();
        }

        public static void LoadGame()
        {
            switch (Level)
            {
                case 1:
                    //change scenario type
                    AIPlayer = new DemonAI("Jett", "A weak gremlin");
                    Background = Background.Church_Day;
                    break;
                case 2:
                    AIPlayer = new DemonAI("Archie", "A mid tier demon", 100);
                    Background = Background.Farm_Day;
                    break;
                case 3:
                    AIPlayer = new DemonAI("DaVinchi", "A top tier demon", 150);
                    Background = Background.Garden_Day;
                    break;
                case 4:
                    AIPlayer = new AIScientist("Harry Pottery", "A powerful Wizard", 150);
                    Background = Background.Semetary_Night;
                    break;
                case 5:
                    AIPlayer = new AIScientist("Voldermort", "The most powerful Wizard", 500);
                    Background = Background.Park_Night;
                    break;
                default:
                    break;
            }
        }


    }
}
