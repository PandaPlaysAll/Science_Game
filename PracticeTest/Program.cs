using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace PracticeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceController resources = new ResourceController();
            resources.PlayMusic();
            MenuController menu = new MenuController();
            menu.StartMenu();


            


            Console.ReadKey();
        }
    }
}
