using System;
using System.Collections.Generic;
//using System.Linq;

namespace ND2
{
    class Program
    {
        static void Main()
        {
            List<int> skaiciai = new List<int>();

            //   int skaicius = 192756;
            //  int[] skaiciuMasyvas = new int[6];
            //  int[] a1 = new int[] { 1, 2, 4, 3 };
            //  int[] a2 = new int[] { 4, 3, 2, 1 };
        //    List<bool> bolenas = new List<bool>(); 
        //    int [] daugikliai = new int[] {2,3,4,5,6};

            //Console.WriteLine(ConvertIntToIntArray(skaicius));

               foreach (int item in sugeneruotiSesiazenkliusSkaicius(skaiciai))
               {
                if (IsArrayValuesUnique(ConvertIntToIntArray(item)))
                {
                         int padaugintaIs2 = item * 2;
                         int padaugintaIs3 = item * 3;
                         int padaugintaIs4 = item * 4;
                         int padaugintaIs5 = item * 5;
                         int padaugintaIs6 = item * 6;

                        if (DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs2)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs3)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs4)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs5)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs6)))
                        {
                            Console.WriteLine("Magiškas sesiazenklis skaicius yra: " + item);
                        }

                   
                }
                } 
               }

          //  Console.WriteLine(CompareTwoArrays(a1, a2));

            static int[] ConvertIntToIntArray(int skaicius)
            {
                string laikinas = skaicius.ToString();
                //   Console.WriteLine(laikinas);
                //char[] simboliuMasyvas = laikinas.ToCharArray();
                int[] skaiciuMasyvas = new int[laikinas.Length];
                for (int i = 0; i < laikinas.Length; i++)
                {
                    char simbolis = laikinas[i];
                    // Console.WriteLine(simbolis);
                    int skaiciusSk = int.Parse(simbolis.ToString());
                    //   Console.WriteLine(skaiciusSk);
                    skaiciuMasyvas[i] = skaiciusSk;

                }
                return skaiciuMasyvas;
            }


            static bool IsArrayValuesUnique(int[] skaiciuMasyvas)
            {
                for (int i = 0; i < skaiciuMasyvas.Length; i++)
                {
                    for (int j = i + 1; j < skaiciuMasyvas.Length; j++)
                    {
                        if (skaiciuMasyvas[i] == skaiciuMasyvas[j])
                        {
                             return false;
                        }
                    }
                }
              return true;
                
                /*  su linqu          
                 *                 List<int> laikinasListas = new List<int>();
                                   laikinasListas.AddRange(skaiciuMasyvas);
                 *  
                 *  
                  if (laikinasListas.Distinct().Count() == laikinasListas.Count())
                   {
                      return true;
                  }
                  return false;
                */
            }



            static bool DoTwoArraysHaveSameElementsButInDifferentIndexes(int[] skaiciuMasyvas, int[] skaiciuMasyvas2)
            {
                if (skaiciuMasyvas.Length == skaiciuMasyvas2.Length)
                {
                    List<int> listDiff = new List<int>();

                    int[] pirmasLaikinasMasyvas = (int[])skaiciuMasyvas.Clone();
                    int[] antrasLaikinasMasyvas = (int[])skaiciuMasyvas2.Clone();
                    Array.Sort(pirmasLaikinasMasyvas);
                    Array.Sort(antrasLaikinasMasyvas);

                    for (int i = 0; i < pirmasLaikinasMasyvas.Length; i++)
                    {
                        if (pirmasLaikinasMasyvas[i] != antrasLaikinasMasyvas[i])
                        {
                            return false;
                        }
                    }

                    for (int k = 0; k < skaiciuMasyvas.Length; k++)
                    {
                        if (skaiciuMasyvas[k] != skaiciuMasyvas2[k])
                        {
   //                         Console.WriteLine("good");
                            listDiff.Add(k);
                        }
   //                     else
   //                         Console.WriteLine("bad");
                    }

                    if (listDiff.Count == skaiciuMasyvas.Length)
                    {
                        return true;
                    }
                    return false;
                }           
                return false;

                /* su linqu butu tik tiek:
                if (skaiciuMasyvas.Count() == skaiciuMasyvas2.Count() && !skaiciuMasyvas.Except(skaiciuMasyvas2).Any())
                {
                    return true;
                }
                return false;
                */
            }


            static List<int> sugeneruotiSesiazenkliusSkaicius(List<int> skaiciai)
            {
                for (int i = 100000; i < 1000000; i++)
                {
                    skaiciai.Add(i);
                }
            return skaiciai;
            }

        }
    }
    

