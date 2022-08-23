using Models;
using Models.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Council.Elders.ElderTypes.Consul
{
    public class Consul : Elder
    {
        private string GAME_START_GREETING(string chieftainName, string hamletName) => $"Hello and welcome new {chieftainName} to your Hamlet named, {hamletName}. There are many things to learn about running our small corner of the world and you will learn all of it in due time. My name is {this.Name} For now, enjoy the beer and bread. One thing you will learn is that it is good to be chieftain.";
        private string NEXT_TURN_TEXT(string chieftainTitle, string chieftainName, int turnNumber, string eldersTitles) => $"\nGreetings {chieftainTitle } {chieftainName}, this is Gathering of the {eldersTitles} {turnNumber} . \n";
        private string MENU_ONE_OPTIONS(string frontOfMessage) => $"\n{frontOfMessage}\n1. Get City Stats." +
            "\n2. Stare into the abyss." +
            "\n9. End turn.\n";

        public Consul(string Name)
        {
            this.Name = Name;
        }

        public void IntroduceGame(string chieftainName = "Chieftain", string hamletName = "Abbelin")
        {
            PrinterUtility.Print(GAME_START_GREETING(chieftainName, hamletName));
        }

        public void PromptNextTurn(GlobalVariables data)
        {
            PrinterUtility.Print(NEXT_TURN_TEXT(data.chieftainTitle, data.chieftainName, data.turnNumber, data.eldersTitles));
            PrinterUtility.Print("News since the last gathering:");
            PrinterUtility.PrintNews(data.News);
        }

        public void StartMenuOptions(int count)
        {
            switch (count)
            {
                case 1:
                    PrinterUtility.Print(MENU_ONE_OPTIONS("There is much to discuss, what would you like to discuss first ?\n"));
                    break;
                case 2:
                    PrinterUtility.Print(MENU_ONE_OPTIONS("Anything else sir?"));
                    break;
                case 3:
                    PrinterUtility.Print(MENU_ONE_OPTIONS("The men are looking tired of this..."));
                    break;
                default:
                    PrinterUtility.Print(MENU_ONE_OPTIONS("Mmmhmm and... ?"));
                    break;                
            }
        }

        public int GetMenuChoice()
        {
            return PrinterUtility.ConvertResponseIntoNumber(PrinterUtility.GetResponse());
        }

        public bool SelectMenu(int response, GlobalVariables data)
        {
            switch (response)
            {
                case 1:
                    //print stats
                    PrinterUtility.PrintBuildings(data.buildings);
                    return true;
                case 2:
                    //stare into abyss
                    PrinterUtility.Print("Everyone awkwardly stares into nothing. ");
                    return true;
                default:
                    //end turn
                    return false;
            }
        }
    }
}
