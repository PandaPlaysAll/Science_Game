using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public class MenuController
    {
        public MenuController()
        {

        }

        public void StartMenu()
        {
            ConsoleKey key = new ConsoleKey();
            Console.CursorVisible = false;
            int currentSelection = 0;


            List<string> menu = new List<string>()
            {
                "Play",
                "Scores",
                "Exit",
                //show what potions u can form
            };

            do
            {
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(menu[i]);
                    Console.ResetColor();

                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            break;
                        default:
                            break;
                    }
                } 
            } while (key != ConsoleKey.Enter);
        }
        //drawMenu method
        //change Console background color per mode?

        //push stack model -> Change different view
        //main menu
        //game menu



    }
}
