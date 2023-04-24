using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagageSortering
{
    internal class Luggage
    {
        internal string TerminalID = Randoms.TerminalID();
        internal string LuggageType = Randoms.LuggageType();
    }

    internal class Randoms
    {
        public static string TerminalID()
        {
            int rnd = Random.Shared.Next(0, 3);
            string type;

            if (rnd == 1)
            {
                type = "Terminal 1";
                return type;
            }
            if (rnd == 2)
            {
                type = "Terminal 2";
                return type;
            }
            else
            {
                type = "Terminal 3";
                return type;

            }

        }

        public static string LuggageType()
        {
            int rnd = Random.Shared.Next(0, 3);
            string type;

            if (rnd == 1)
            {
                type = "suitcase";
                return type;
            }
            if (rnd == 2)
            {
                type = "duffel bag";
                return type;
            }
            else
            {
                type = "animal crate";
                return type;

            }

        }
    }
}
