using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public static class MenuController
{
        private static Stack<Gamestate> _state;
        private static List<string> _mainMenu;
        private static List<string> _gameMenu;
        private static List<string> _currentMenu;
        private static int _currentSelection;

        static MenuController()
        {
            _currentMenu = new List<string>();
            _mainMenu = new List<string>()
            {
                "Play",
                "Scores",
                "Exit",
                "Mute",
                //show what potions u can form
            };

            if (GameLogic.HumanPlayer is Scientist)
            {
                _gameMenu = new List<string>()
                {
                    "Attack",
                    "Heal",
                    "ViewInventory",
                    "FormPotion",
                    "Back",
                };
            } else { 
                    _gameMenu = new List<string>()
                    {
                        "Attack",
                        "Heal",
                        "ViewInventory",
                        "Back",
                    };
                }

            _state = new Stack<Gamestate>();
            ChangeState(Gamestate.ViewingMainMenu);
            _currentMenu = _mainMenu;
            _currentSelection = 0;

        }

        public static void HandleState()
        {
            Console.Clear();
            switch (_state.Peek())
            {
                case Gamestate.ViewingEndGame:
                    {
                        break;
                    }
                case Gamestate.ViewingGameMenu:
                    {
                        _currentMenu = _gameMenu;
                        StartMenu();
                        
                        break;
                    }
                case Gamestate.ViewingHighScores:
                    {
                        break;
                    }

                case Gamestate.ViewingMainMenu:
                    {
                        _currentMenu = _mainMenu;
                        StartMenu();
                        break;
                    }

                case Gamestate.ViewingQuit:
                    {
                        Environment.Exit(1);
                        break;
                    }
            }
        }

        public static void EndState()
        {
            _state.Pop();
        }

        public static void ChangeState(Gamestate state)
        {
            _state.Push(state);
        }


        

        public static void StartMenu()
        {
            
            ConsoleKey key = new ConsoleKey();
            Console.CursorVisible = false;

            

            do
            {
                
                Console.WriteLine("Use Up and Down arrows and enter button to choose the gamemode");
                for (int i = 0; i < _currentMenu.Count; i++)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (_currentSelection == i)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(_currentMenu[i]);
                   



                    Console.ResetColor();
                }

                

                key = Console.ReadKey(true).Key;
                var completed = key == ConsoleKey.Enter;

                if (_state.Peek() == Gamestate.ViewingMainMenu) { 
                    if (completed && (_currentSelection == 0))
                    {
                        ChangeState(Gamestate.ViewingGameMenu);
                        HandleState();
                    }
                    else if (completed && (_currentSelection == 1))
                    {
                        ChangeState(Gamestate.ViewingHighScores);
                        HandleState();
                    } else if (completed && (_currentSelection == 2))
                    {
                        ChangeState(Gamestate.ViewingQuit);
                        HandleState();
                    }
                    else if (completed && (_currentSelection == 3))
                    {
                        if (Extensible.IsPlaying == true)
                        {
                            ResourceController.StopMusic();
                            Extensible.IsPlaying = false;
                            _mainMenu = new List<string>()
                            {
                                "Play",
                                "Scores",
                                "Exit",
                                "Unmute",
                                //show what potions u can form
                            };
                        } else if (Extensible.IsPlaying == false)
                        {
                            ResourceController.PlayMusic();
                            Extensible.IsPlaying = true;
                            _mainMenu = new List<string>()
                            {
                                "Play",
                                "Scores",
                                "Exit",
                                "Mute",
                                //show what potions u can form
                            };
                        }
                        
                        HandleState();
                    }
                }

                if (_state.Peek() == Gamestate.ViewingGameMenu && GameLogic.HumanPlayer is Scientist)
                {
                    if (completed && (_currentSelection == 0))
                    {
                        Console.Clear();
                        GameLogic.AttackSequence();

                    }
                    else if (completed && (_currentSelection == 1))
                    {
                        //heal here
                    }
                    else if (completed && (_currentSelection == 2))
                    {
                        Console.Clear();
                        Console.WriteLine(GameLogic.HumanPlayer.Inventory.PrintInventory());
                        if (((Scientist)GameLogic.HumanPlayer).Potion.Count > 0)
                            Console.WriteLine("{0}", ((Scientist)GameLogic.HumanPlayer).PrintPotions());

                    }
                    else if (completed && (_currentSelection == 3))
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Potion name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter a number for the Potion Type!\n0: Position_Ivy\n1: Light_Fury\n2: Buff_Buff\n3: Dark_Matter\n4: Dark_Matter\n5: Healthy_Wealthy\n");
                        int i = Convert.ToInt32(Console.ReadLine());
                        ((Scientist)GameLogic.HumanPlayer).FormPotion(((PotionType)i), name);
                        if (((Scientist)GameLogic.HumanPlayer).Potion.Count > 0)
                            Console.WriteLine("{0}", ((Scientist)GameLogic.HumanPlayer).PrintPotions());

                    }
                    else if (completed && (_currentSelection == 4))
                    {
                        EndState();
                        ChangeState(Gamestate.ViewingMainMenu);
                        HandleState();
                    }
                }
                else if (_state.Peek() == Gamestate.ViewingGameMenu)
                {
                    if (completed && (_currentSelection == 0))
                    {
                        Console.Clear();
                        GameLogic.AttackSequence();
                        
                    }
                    else if (completed && (_currentSelection == 1))
                    {
                        //heal here
                    } else if (completed && (_currentSelection == 2))
                    {
                        Console.Clear();
                        Console.WriteLine(GameLogic.HumanPlayer.Inventory.PrintInventory());
                        if (((Scientist)GameLogic.HumanPlayer).Potion.Count > 0)
                            Console.WriteLine("{0}", ((Scientist)GameLogic.HumanPlayer).PrintPotions());
                        
                    }
                    else if (completed && (_currentSelection == 3))
                    {
                        EndState();
                        ChangeState(Gamestate.ViewingMainMenu);
                        HandleState();
                    }
                }


                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            if (_currentSelection < (_currentMenu.Count - 1))
                                _currentSelection += 1;
                            if (_state.Peek().Equals(Gamestate.ViewingGameMenu) && (_currentSelection == 0) || (_state.Peek().Equals(Gamestate.ViewingGameMenu) && (_currentSelection == 2)))
                            {
                                //do nothing
                            }
                                HandleState();                            
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (_currentSelection > 0)
                                _currentSelection -= 1;
                            
                            if (_state.Peek().Equals(Gamestate.ViewingGameMenu) && (_currentSelection == 0) || (_state.Peek().Equals(Gamestate.ViewingGameMenu) && (_currentSelection == 2)))
                            {
                                //do nothing 
                            }
                                HandleState();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            EndState();
                            HandleState();
                            break;
                        }
                    case ConsoleKey.Enter:
                        break;
                    default:
                        HandleState();
                        break;
                        //how to deal with weird stuff? clear screen, if arrow is left or rightg... but need to print desc to 
                }

                

            } while (_state.Peek() != Gamestate.ViewingQuit);

            //if in play game. Set the AIPlayer to a certain object dependant on GameLevel i.e start with the AIDemon? which could just be a Demon. not AI...
        }


        //drawMenu method
        //change Console background color per mode?

        //push stack model -> Change different view
        //main menu
        //game menu



    }
}
