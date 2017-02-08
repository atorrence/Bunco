using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunco.Class;

namespace Bunco.Class
{
    class Month
    {

        private string host;
        public string Host
        {
            get
            {
                return host;
            }
        }
        private string calendarMonth;
        public string CalendarMonth
        {
            get
            {
                return calendarMonth;
            }
        }

        private string[] wineBringers;
        public string[] WineBringers
        {
            get
            {
                return wineBringers;
            }
        }
        private string[] appetizerBringers;
        public string[] AppetizerBringers
        {
            get
            {
                return appetizerBringers;
            }
        }
        private string[] beerBringers;
        public string[] BeerBringers
        {
            get
            {
                return beerBringers;
            }
        }
        private string[] dessertBringers;
        public string[] DessertBringers
        {
            get
            {
                return dessertBringers;
            }
        }

        public List<Player> MakeAssignments(List<Player> players)
        {
            return null;
        }

    }
}
