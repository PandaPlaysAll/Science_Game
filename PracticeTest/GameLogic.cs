using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    public static class GameLogic
    {
        //declaration
        private static Character _humanPlayer;
        private static Character _aiPlayer;
        private static Scenario _scenario;
        private static Background _background;

        
      
        //properties
        public static Character HumanPlayer { get { return _humanPlayer; } set { _humanPlayer = value; } }
        public static Character AIPlayer { get { return _aiPlayer; } set { _aiPlayer = value; } }
        public static Scenario Scenario { get { return _scenario; } set { _scenario = value; } }
        public static Background Background { get { return _background; } set { _background = value; } }

        //let user choose player,


        //GUI / Consolebased
        //create players here?
        public static void CreateGame(Character p)
        {
            MenuController.StartMenu();
            //Menu Controller should change things
            //be able to handle the different modes
        }

        public static void AttackSequence()
        {
            //if (a is Scientist) 
            HumanPlayer.Attack(AIPlayer);
            AIPlayer.Attack(HumanPlayer);
            GameItems.RandomItem(AIPlayer);
            GameItems.RandomItem(HumanPlayer);
        }
    }
}
