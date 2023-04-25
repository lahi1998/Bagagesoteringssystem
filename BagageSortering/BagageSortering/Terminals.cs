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
                // Use a lock statement to synchronize access to the Terminal1 array.
                lock (Terminal1)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal1.Length; i++)
                            {
                                if (Terminal1[i] != null)
                                {
                                    Terminal1[i] = null;
                                    Thread.Sleep(timer);
                                }
                                // Call the method to updater counters (Updating it for the display.)
                                CounterPortArrays();
                            }

                            // Set the LoadingPlane variable to false and signal all waiting threads.
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal1);
                        }
                    }
                    catch (Exception e)
                    {
                        // Log any exceptions that occur.
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
                // Use a lock statement to synchronize access to the Terminal2 array.
                lock (Terminal2)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal2.Length; i++)
                            {

                                if (Terminal2[i] != null)
                                {
                                    Terminal2[i] = null;
                                    Thread.Sleep(timer);
                                    // Call the method to updater counters (Updating it for the display.)
                                    CounterPortArrays();
                                }
                            }
                            // Set the LoadingPlane variable to false and signal all waiting threads.
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal2);
                        }
                    }
                    catch (Exception e)
                    {
                        // Log any exceptions that occur.
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
                // Use a lock statement to synchronize access to the Terminal3 array.
                lock (Terminal3)
                {
                    try
                    {
                        if (LoadingPlane == true)
                        {
                            for (int i = 0; i < Terminal3.Length; i++)
                            {
                                if (Terminal3[i] != null)
                                {
                                    Terminal3[i] = null;
                                    Thread.Sleep(timer);
                                    // Call the method to updater counters (Updating it for the display.)
                                    CounterPortArrays();
                                }
                            }
                            // Set the LoadingPlane variable to false and signal all waiting threads.
                            LoadingPlane = false;
                            Monitor.PulseAll(Terminal3);
                        }
                    }
                    catch (Exception e)
                    {
                        // Log any exceptions that occur.
                        Debug.Write(e);
                    }
                }
            }
        }
    }
}
