using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;
using static BagageSortering.Counters;

namespace BagageSortering
{
    internal class Terminals
    {
        public static void CargoTerminal1()
        {
            bool run = true;
            while (run == true)
            {
                lock (Terminal1)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal1.Length; i++)
                            {
                                CounterPortArrays();
                                if (Terminal1[i] != null)
                                {
                                    Terminal1[i] = null;
                                    Thread.Sleep(timer);
                                }
                            }
                            CounterPortArrays();
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal1);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.Write(e);
                    }
                }
            }
        }

        public static void CargoTerminal2()
        {
            bool run = true;
            while (run == true)
            {
                lock (Terminal2)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal2.Length; i++)
                            {
                                CounterPortArrays();
                                if (Terminal2[i] != null)
                                {
                                    Terminal2[i] = null;
                                    Thread.Sleep(timer);
                                }
                            }
                            CounterPortArrays();
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal2);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.Write(e);
                    }
                }
            }
        }
        public static void CargoTerminal3()
        {
            bool run = true;
            while (run == true)
            {
                lock (Terminal3)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal3.Length; i++)
                            {
                                CounterPortArrays();
                                if (Terminal3[i] != null)
                                {
                                    Terminal3[i] = null;
                                    Thread.Sleep(timer);
                                }
                            }
                            CounterPortArrays();
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal3);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.Write(e);
                    }
                }
            }
        }
    }
}
