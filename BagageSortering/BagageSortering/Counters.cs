using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace BagageSortering
{
    internal class Counters
    {
        public static void CounterSorterArray()
        {
            int counter = 0, displayerCount = 0;

            for (int i = 0; i < Sorterarr.Length; i++)
            {
                if (Sorterarr[i] == null)
                {
                    counter++;
                }
            }
            for (int i = 0; i < Sorterarr.Length; i++)
            {
                if (Sorterarr[i] != null)
                {
                    displayerCount++;
                }
            }

            count = counter;

            count2 = displayerCount;

        }

        public static void CounterPortArrays()
        {
            CountTerminal1 = 0;
            CountTerminal1Animal = 0;
            CountTerminal1Duffel = 0;
            CountTerminal1SuitCase = 0;
            CountTerminal2 = 0;
            CountTerminal2Animal = 0;
            CountTerminal2Duffel = 0;
            CountTerminal2SuitCase = 0;
            CountTerminal3 = 0;
            CountTerminal3Animal = 0;
            CountTerminal3Duffel = 0;
            CountTerminal3SuitCase = 0;

            for (int i = 0; i < Terminal1.Length; i++)
            {
                if (Terminal1[i] != null && ((Luggage)Terminal1[i]).LuggageType == "suitcase")
                {
                    CountTerminal1++;
                    CountTerminal1SuitCase++;
                }
                else if (Terminal1[i] != null && ((Luggage)Terminal1[i]).LuggageType == "duffel bag")
                {
                    CountTerminal1++;
                    CountTerminal1Duffel++;
                }
                else if (Terminal1[i] != null && ((Luggage)Terminal1[i]).LuggageType == "animal crate")
                {
                    CountTerminal1++;
                    CountTerminal1Animal++;
                }
            }

            for (int i = 0; i < Terminal2.Length; i++)
            {
                if (Terminal2[i] != null && ((Luggage)Terminal2[i]).LuggageType == "suitcase")
                {
                    CountTerminal2++;
                    CountTerminal2SuitCase++;
                }
                else if (Terminal2[i] != null && ((Luggage)Terminal2[i]).LuggageType == "duffel bag")
                {
                    CountTerminal2++;
                    CountTerminal2Duffel++;
                }
                else if (Terminal2[i] != null && ((Luggage)Terminal2[i]).LuggageType == "animal crate")
                {
                    CountTerminal2++;
                    CountTerminal2Animal++;
                }
            }

            for (int i = 0; i < Terminal3.Length; i++)
            {
                if (Terminal3[i] != null && ((Luggage)Terminal3[i]).LuggageType == "suitcase")
                {
                    CountTerminal3++;
                    CountTerminal3SuitCase++;
                }
                else if (Terminal3[i] != null && ((Luggage)Terminal3[i]).LuggageType == "duffel bag")
                {
                    CountTerminal3++;
                    CountTerminal3Duffel++;
                }
                else if (Terminal3[i] != null && ((Luggage)Terminal3[i]).LuggageType == "animal crate")
                {
                    CountTerminal3++;
                    CountTerminal3Animal++;
                }
            }
        }
    }
}
