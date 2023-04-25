using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace BagageSortering
{
    internal class CentralServer
    {
        public static void Displayboard()
        {
            Console.CursorVisible = false;
            string lastrun = "Conveyor3";
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("---------------------");
                Console.WriteLine("Sorter        : {0} ", count2);
                Console.WriteLine("---------------------");
                Console.WriteLine("Terminal 1    : {0} ", CountTerminal1);
                Console.WriteLine("Suitcases     : {0} ", CountTerminal1SuitCase);
                Console.WriteLine("Duffel bags   : {0} ", CountTerminal1Duffel);
                Console.WriteLine("Animal crate  : {0} ", CountTerminal1Animal);
                Console.WriteLine("---------------------");
                Console.WriteLine("Terminal 2    : {0} ", CountTerminal2);
                Console.WriteLine("Suitcases     : {0} ", CountTerminal2SuitCase);
                Console.WriteLine("Duffel bags   : {0} ", CountTerminal2Duffel);
                Console.WriteLine("Animal crate  : {0} ", CountTerminal2Animal);
                Console.WriteLine("---------------------");
                Console.WriteLine("Terminal 3    : {0} ", CountTerminal3);
                Console.WriteLine("Suitcases     : {0} ", CountTerminal3SuitCase);
                Console.WriteLine("Duffel bags   : {0} ", CountTerminal3Duffel);
                Console.WriteLine("Animal crate  : {0} ", CountTerminal3Animal);
                Console.WriteLine("---------------------");

                if (lastrun == "Conveyor3")
                {
                    Conveyor1();
                    lastrun = "Conveyor1";
                }
                if (lastrun == "Conveyor1")
                {
                    Conveyor2();
                    lastrun = "Conveyor2";
                }
                if (lastrun == "Conveyor2")
                {
                    Conveyor3();
                    lastrun = "Conveyor3";
                }
            }
        }


        private static void Conveyor1()
        {
            Console.SetCursorPosition(24, 10);
            Console.WriteLine(" []  []  []  []  []  []  []  []  []  []  [");
            Console.SetCursorPosition(24, 11);
            Console.WriteLine("|-----------------------------------------|");
            Console.SetCursorPosition(24, 12);
            Console.WriteLine("|-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-|");
            Console.SetCursorPosition(24, 13);
            Console.WriteLine("|-----------------------------------------|");
            Thread.Sleep(timer - 10);
        }

        private static void Conveyor2()
        {
            Console.SetCursorPosition(24, 10);
            Console.WriteLine("   []  []  []  []  []  []  []  []  []  []  ");
            Console.SetCursorPosition(24, 11);
            Console.WriteLine("|-----------------------------------------|");
            Console.SetCursorPosition(24, 12);
            Console.WriteLine("|-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-|");
            Console.SetCursorPosition(24, 13);
            Console.WriteLine("|-----------------------------------------|");
            Thread.Sleep(timer - 10);
        }

        private static void Conveyor3()
        {
            Console.SetCursorPosition(24, 10);
            Console.WriteLine(" ]  []  []  []  []  []  []  []  []  []  [] ");
            Console.SetCursorPosition(24, 11);
            Console.WriteLine("|-----------------------------------------|");
            Console.SetCursorPosition(24, 12);
            Console.WriteLine("|-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-|");
            Console.SetCursorPosition(24, 13);
            Console.WriteLine("|-----------------------------------------|");
            Thread.Sleep(timer - 10);
        }
    }
}
