using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;
using static BagageSortering.Counters;
using System.Diagnostics;

namespace BagageSortering
{
    internal class SorterMachine
    {
        public static void Sorter()
        {
            while (true)
            {
                // Acquire locks on all the shared arrays,
                // using monitor because im entering multiple arrays, found it easier to see what i was doing 
                Monitor.Enter(Sorterarr);
                Monitor.Enter(Terminal1);
                Monitor.Enter(Terminal2);
                Monitor.Enter(Terminal3);
                try
                {
                    CounterSorterArray();
                    // If the array is empty waits for pulse from checkincounters
                    if (count != 0)
                    {
                        Monitor.Wait(Sorterarr);
                    }
                    for (int i = 0; i < buffersize; i++)
                    {
                        // updating counters for counterports to see if theres any space.
                        CounterPortArrays();
                        // And soter array for display.
                        CounterSorterArray();
                        if (Sorterarr[i] != null && ((Luggage)Sorterarr[i]).TerminalID == "Terminal 1")
                        {
                            // If Terminal 1 is full, set the LoadingPlane flag to true and wait until there is space available.
                            if (CountTerminal1 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal1);
                            }
                            // Find the first empty slot in Terminal 1 and add the luggage to it
                            for (int i1 = 0; i1 < Terminal1.Length; i1++)
                            {
                                if (Terminal1[i1] == null)
                                {
                                    Terminal1[i1] = Sorterarr[i];
                                    Sorterarr[i] = null;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }

                        }
                        if (Sorterarr[i] != null && ((Luggage)Sorterarr[i]).TerminalID == "Terminal 2")
                        {
                            // If Terminal 2 is full, set the LoadingPlane flag to true and wait until there is space available.
                            if (CountTerminal2 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal2);
                            }
                            // Find the first empty slot in Terminal 2 and add the luggage to it
                            for (int i1 = 0; i1 < Terminal2.Length; i1++)
                            {
                                if (Terminal2[i1] == null)
                                {
                                    Terminal2[i1] = Sorterarr[i];
                                    Sorterarr[i] = null;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }

                        }
                        if (Sorterarr[i] != null && ((Luggage)Sorterarr[i]).TerminalID == "Terminal 3")
                        {
                            // If Terminal 3 is full, set the LoadingPlane flag to true and wait until there is space available.
                            if (CountTerminal3 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal3);
                            }
                            // Find the first empty slot in Terminal 3 and add the luggage to it
                            for (int i1 = 0; i1 < Terminal3.Length; i1++)
                            {
                                if (Terminal3[i1] == null)
                                {
                                    Terminal3[i1] = Sorterarr[i];
                                    Sorterarr[i] = null;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }

                        }
                    }
                    // Update counters and wake up any waiting threads
                    CounterPortArrays();
                    Monitor.PulseAll(Sorterarr);
                    Monitor.PulseAll(Terminal1);
                    Monitor.PulseAll(Terminal2);
                    Monitor.PulseAll(Terminal3);
                }
                catch (Exception e)
                {
                    // Log any exceptions that occur.
                    Debug.Write(e);
                }
                finally
                {
                    // Exits all threads
                    Monitor.Exit(Sorterarr);
                    Monitor.Exit(Terminal1);
                    Monitor.Exit(Terminal2);
                    Monitor.Exit(Terminal3);
                }
            }
        }
    }
}

