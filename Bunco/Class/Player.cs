using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunco.Class;

namespace Bunco.Class
{
    class Player
    {
        private string playerName;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
        }

        private string hostMonth;
        public string HostMonth
        {
            get
            {
                return hostMonth;
            }
        }

        private bool isHost;
        private bool isOrganizer;
        private int timesbroughtWine;
        public int TimesbroughtWine
        {
            get
            {
                return timesbroughtWine;
            }
        }
        private int timesbroughtAppetizer;
        public int TimesbroughtAppetizer
        {
            get
            {
                return timesbroughtAppetizer;
            }
        }
        private int timesbroughtDessert;
        public int TimesbroughtDessert
        {
            get
            {
                return timesbroughtDessert;
            }
        }
        private int timesbroughtBeer;
        public int TimesbroughtBeer
        {
            get
            {
                return timesbroughtBeer;
            }
        }

        public Player(string name, string hostMonth)
        {
            this.playerName = name;
            this.hostMonth = hostMonth;
        }
    }
}
