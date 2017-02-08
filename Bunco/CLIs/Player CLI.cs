using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunco.Class;

namespace Bunco.CLIs
{
    class Player_CLI
    {

        public List<Players> CreatePlayerList(string name, string hostMonth)
        {
            List<Players> newListOfPlayers = new List<Players>();
            while (true)
            {
                Console.Write("Enter last name, first name:");
                string fullName = Console.ReadLine();
                Console.WriteLine($"If {fullName} will host this season, please enter her host month.");
                Console.WriteLine("If she is not hosting this season, just press enter.");
                string month = Console.ReadLine();
                Console.WriteLine("Enter End when all players have been entered");
                Player n = new Player(fullName, month);
                newListOfPlayers.Add(n);


            }
        }


}
}
