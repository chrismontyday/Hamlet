using Council.Elders.ElderTypes.Architecture;
using Council.Elders.ElderTypes.Consul;
using Council.Elders.ElderTypes.News;
using Council.Elders.ElderTypes.WorkForce;
using Models;
using System;
using System.Collections.Generic;

namespace Hamlet
{
    public class Program
    {
        public static GlobalVariables data;
        public static Builder elderFred;
        public static Consul consul;
        public static Overseer overseer;
        public static Reporter reporter;

        static void Main(string[] args)
        {
            SetUpGame();
            GameLoop();
        }

        #region Game Loops

        public static void GameLoop()
        {
            consul.IntroduceGame(data.chieftainName, data.hamletName);

            while (data.gameOn)
            {
                //Print turn menu
                consul.PromptNextTurn(data);

                //Get Orders
                GetOrders();
            }
        }

        static void GetOrders()
        {
            bool turnStillGoing = true;
            int count = 1;

            consul.StartMenuOptions(count);

            while (turnStillGoing)
            {
                int choice = consul.GetMenuChoice();

                turnStillGoing = consul.SelectMenu(choice, data);

                if (turnStillGoing)
                {
                    consul.StartMenuOptions(count++);
                }
            }
            
            data = EndTurn(data);
        }

        static GlobalVariables EndTurn(GlobalVariables data)
        {
            data.News.Clear();
            data.turnNumber++;
            data.buildings = overseer.DriveWork(data.buildings);
            data.News.Add(reporter.ReturnRandomReport());

            if (data.turnNumber == 100)
            {
                data.chieftainTitle = "established";
            }

            return data;
        }

        #endregion

        #region Game Start Up

        public static void SetUpGame(int numOfBuilding = 4)
        {
            data = new GlobalVariables
            {
                gameOn = true,                
                turnNumber = 1,
                chieftainName = "Chieftain",
                chieftainTitle = "new",
                eldersTitles = "Elders",
                hamletName = "Abbelin",
                News = new List<String>()
            };

            elderFred = new Builder("Fred");
            consul = new Consul("Emmanual");
            overseer = new Overseer("Franklin");
            reporter = new Reporter("Grunbintu");
            
            data.buildings = elderFred.ConstructBuildings();           

        }

        #endregion
    }
}
