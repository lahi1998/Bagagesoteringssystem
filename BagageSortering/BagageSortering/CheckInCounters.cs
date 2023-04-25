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
    internal class CheckInCounters
    {
        public static void CheckInCounter1()
        {

            while (true)
            {
                // acquire the lock for the sorter array
                lock (Sorterarr)
                {
                    try
                    {
                        CounterSorterArray();
                        // When the sorterarr is full and no plane is being loaded,
                        // so the softer know the array is free, and resumes then waits for the sortet to pulse and resumes
                        // with filling the sorterarr.
                        if (count == 0 && LoadingPlane == false)
                        {
                            Monitor.PulseAll(Sorterarr);
                            Monitor.Wait(Sorterarr);
                        }
                        if (count >= 0)
                        {
                            for (int i = 0; i < Sorterarr.Length; i++)
                            {
                                if (Sorterarr[i] == null)
                                {
                                    Luggage obj = new Luggage();
                                    Sorterarr[i] = obj;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }
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

        public static void CheckInCounter2()
        {

            while (true)
            {
                // acquire the lock for the sorter array
                lock (Sorterarr)
                {
                    try
                    {
                        CounterSorterArray();
                        // When the sorterarr is full and no plane is being loaded,
                        // so the softer know the array is free, and resumes then waits for the sortet to pulse and resumes
                        // with filling the sorterarr.
                        if (count == 0 && LoadingPlane == false)
                        {
                            Monitor.PulseAll(Sorterarr);
                            Monitor.Wait(Sorterarr);
                        }
                        if (count != 0)
                        {
                            for (int i = 0; i < Sorterarr.Length; i++)
                            {
                                if (Sorterarr[i] == null)
                                {
                                    Luggage obj = new Luggage();

                                    Sorterarr[i] = obj;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }
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

        public static void CheckInCounter3()
        {

            while (true)
            {
                // acquire the lock for the sorter array
                lock (Sorterarr)
                {
                    try
                    {
                        CounterSorterArray();
                        // When the sorterarr is full and no plane is being loaded,
                        // so the softer know the array is free, and resumes then waits for the sortet to pulse and resumes
                        // with filling the sorterarr.
                        if (count == 0 && LoadingPlane == false)
                        {
                            Monitor.PulseAll(Sorterarr);
                            Monitor.Wait(Sorterarr);
                        }
                        if (count != 0)
                        {
                            for (int i = 0; i < Sorterarr.Length; i++)
                            {
                                if (Sorterarr[i] == null)
                                {
                                    Luggage obj = new Luggage();

                                    Sorterarr[i] = obj;
                                    Thread.Sleep(timer);
                                    break;
                                }
                            }
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