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
                Monitor.Enter(Sorterarr);
                Monitor.Enter(Terminal1);
                Monitor.Enter(Terminal2);
                Monitor.Enter(Terminal3);
                try
                {
                    CounterSorterArray();
                    if (count != 0)
                    {
                        Monitor.Wait(Sorterarr);
                    }
                    for (int i = 0; i < buffersize; i++)
                    {
                        CounterPortArrays();
                        CounterSorterArray();
                        if (Sorterarr[i] != null && ((Luggage)Sorterarr[i]).TerminalID == "Terminal 1")
                        {
                            if (CountTerminal1 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal1);
                            }
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
                            if (CountTerminal2 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal2);
                            }
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
                            if (CountTerminal3 == buffersize)
                            {
                                LoadingPlane = true;
                                Monitor.Wait(Terminal3);
                            }
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
                    CounterPortArrays();
                    Monitor.PulseAll(Sorterarr);
                    Monitor.PulseAll(Terminal1);
                    Monitor.PulseAll(Terminal2);
                    Monitor.PulseAll(Terminal3);
                }
                catch (Exception e)
                {
                    Debug.Write(e);
                }
                finally
                {
                    Monitor.Exit(Sorterarr);
                    Monitor.Exit(Terminal1);
                    Monitor.Exit(Terminal2);
                    Monitor.Exit(Terminal3);
                }
            }
        }
    }
}

