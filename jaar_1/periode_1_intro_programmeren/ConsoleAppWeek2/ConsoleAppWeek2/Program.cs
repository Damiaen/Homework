using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 verschillende stored values voor result */
            int numberInt = 2;
            int powerInt = 10;
            int resultForInt = 1;
            int resultWhileInt = 1;
            int i = 0;

            int[] value = new int[5];
            int max;

            ///* For loop */
            //for (int x = 0; x < powerInt; x++)
            //{
            //    resultForInt *= numberInt;
            //    Console.WriteLine(resultForInt);
            //}

            ///* While loop */
            //while (powerInt > i)
            //{
            //    resultWhileInt = resultWhileInt * numberInt;
            //    i++;
            //    Console.WriteLine(resultWhileInt);
            //}

            ///* Do while loop */
            //int n = 0;
            //do
            //{
            //    Console.WriteLine(n);
            //    n++;    
            //} while (n < 10);


            //for (int c = 0; c < value.Length; c++)
            //{
            //    value[c] = Convert.ToInt32(Console.ReadLine());
            //}

            //max = value.Max();
            //Console.WriteLine(max);


            /* Opdracht B */

            //int Fib0 = 0;
            //int Fib1 = 1;
            //int Fibn = Fib(n - 1) + Fib(n - 2);

            //for (int y = 0; y < 15; y++)
            //{
            //    Console.WriteLine();
            //}

            /* Opdracht B-1 */
            //int Fib0 = 0;
            //int Fib1 = 1;

            //for (int x = 0; x < 15; x++)
            //{
            //    int temp = Fib0;
            //    Fib0 = Fib1;
            //    Fib1 = temp + Fib1;
            //    Console.WriteLine(Fib1);
            //}

            /* Opdracht B-2 */
            Random random = new Random();
            int dice_roll = random.Next(1, 6);
            int dice_multiplier;
            int dice_score;

            int[] terms = new int[8];

            for (int throws = 0; throws < 4; throws++)
            {

                //int[] local_roll = new int[2];

                int roll1 = random.Next(1, 6);
                Console.WriteLine("Roll 1 value : " + roll1);
                int roll2 = random.Next(1, 6);
                Console.WriteLine("Roll 2 value : " + roll2);

                if (roll1 == 6 & roll2 == 6)
                {
                    Console.WriteLine("2 keer 6");
                }

                if (roll1 == roll2)
                {
                    Console.WriteLine("rolls hetzelfde");
                }

                if (roll1 == 1 & roll2 == 1)
                {
                    Console.WriteLine("2 keer 1");
                }

                //for (roll = 0; roll < 2; roll++)
                //{
                terms[throws] = random.Next(1, 6);
                //    Console.WriteLine("roll: "+roll);
                //}
                    
                Console.WriteLine("throw: " + throws);

            }


            foreach (var item in terms)
            {
                Console.WriteLine(item.ToString());
            }

            //for (int d_roll = 0; d_roll < 4; d_roll++)
            //{
            
            //}


            /* Opdracht C */
            //Console.Clear();
            //for (int x = 0; x < 10; x++)
            //{
            //    for (int y = 0; y < 10; y++)
            //    {
            //        if ((x + y) % 2 == 0)
            //        {
            //            if ((x * y) <= 25)
            //                Console.Write("-");
            //            else
            //                break;
            //        }
            //        else
            //            Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
        }
    }
}
