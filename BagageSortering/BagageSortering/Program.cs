using System.Threading;
using System;
using System.Runtime.ConstrainedExecution;
using System.Linq.Expressions;
using static BagageSortering.CheckInCounters;
using static BagageSortering.SorterMachine;
using static BagageSortering.Terminals;
using static BagageSortering.CentralServer;

static class Program
{
    internal static int buffersize = 19, timer = 200;
    internal static int CountTerminal1, CountTerminal2, CountTerminal3, count, count2, CountTerminal2Duffel,
    CountTerminal1SuitCase, CountTerminal1Duffel, CountTerminal1Animal, CountTerminal2SuitCase,
    CountTerminal2Animal, CountTerminal3SuitCase, CountTerminal3Duffel, CountTerminal3Animal;

    internal static object[] Sorterarr = new object[buffersize];
    internal static object[] Terminal1 = new object[buffersize];
    internal static object[] Terminal2 = new object[buffersize];
    internal static object[] Terminal3 = new object[buffersize];

    internal static bool LoadingPlane = false;

    static void Main()
    {
        Thread d = new Thread(Displayboard);
        d.Name = "Dipsplay";
        d.Priority = ThreadPriority.Normal;
        d.Start();

        Thread c = new Thread(CheckInCounter1);
        c.Name = "CheckInCounter1";
        c.Priority = ThreadPriority.Normal;
        c.Start();

        Thread c1 = new Thread(CheckInCounter2);
        c1.Name = "CheckInCounter2";
        c1.Priority = ThreadPriority.Normal;
        c1.Start();

        Thread c2 = new Thread(CheckInCounter3);
        c2.Name = "CheckInCounter3";
        c2.Priority = ThreadPriority.Normal;
        c2.Start();

        Thread t2 = new Thread(Sorter);
        t2.Name = "Sorter";
        t2.Priority = ThreadPriority.Normal;
        t2.Start();

        Thread t3 = new Thread(CargoTerminal1);
        t3.Name = "CargoTerminal1";
        t3.Priority = ThreadPriority.Normal;
        t3.Start();

        Thread t4 = new Thread(CargoTerminal2);
        t4.Name = "CargoTerminal2";
        t4.Priority = ThreadPriority.Normal;
        t4.Start();

        Thread t5 = new Thread(CargoTerminal3);
        t5.Name = "CargoTerminal3";
        t5.Priority = ThreadPriority.Normal;
        t5.Start();

        c.Join();
        c1.Join();
        c2.Join();
        t2.Join();
        t3.Join();
        t4.Join();
        t5.Join();



    }
}
