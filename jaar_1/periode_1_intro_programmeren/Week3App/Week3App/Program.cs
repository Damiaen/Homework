using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3App
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numberAnmount;
            //Console.WriteLine("Vul in hoeveel nummers er ingevuld kunnen worden: ");
            //numberAnmount = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[numberAnmount]; ;


            //for (int y = 0; y < numbers.Length; y++)
            //{
            //    Console.WriteLine("Vul nu nummer: "+y);
            //    numbers[y] = Convert.ToInt32(Console.ReadLine());

            //}
            //int sum = numbers.Sum();
            //Console.WriteLine("Som van de array: "+sum);

            //Console.WriteLine("Druk een toets om verder te gaan");
            //Console.ReadKey();
            //Console.Clear();

            //int namesArrayAnmount;
            //Console.WriteLine("Vul in hoeveel namen er ingevuld kunnen worden (max 10): ");
            //namesArrayAnmount = Convert.ToInt32(Console.ReadLine());

            //if (namesArrayAnmount > 10)
            //{
            //    Console.WriteLine("Meer dan 10 ingevuld, max namen is naar 10 gezet.");
            //    namesArrayAnmount = 10;
            //}

            //string[] namesArray = new string[namesArrayAnmount];
            //bool namesBool = true;

            ////while (namesBool == true)
            ////{
            //    for (int i = 0; i < namesArray.Length; i++)
            //    {
            //Console.WriteLine("Vul nu naam: " + i + " in.");
            //string input = Console.ReadLine();

            //if (input != string.Empty)
            //{
            //    if (input == "stop")
            //    {
            //        Console.WriteLine("stopped");
            //        namesBool = false;
            //    }

            //    if (input != null && input != "stop")
            //    {
            //        Console.WriteLine("ingevuld");
            //        namesArray[i] = input;

            //    }
            //}
            //else
            //{
            //    while (input == string.Empty)
            //    {
            //        Console.WriteLine("Niks ingevuld, vul aub een naam in: ");
            //        input = Console.ReadLine();
            //        namesArray[i] = input;
            //    }
            //}


            //    }
            ////}


            //foreach (var item in namesArray)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Druk een toets om verder te gaan");
            //Console.ReadKey();
            //Console.Clear();

            /* Opdracht B */

            bool isGoing = true;

            List<bool> boolList = new List<bool>();



            while (isGoing == true)
            {
                Console.WriteLine("Vul een waarde in: ");
                string boolInput = Console.ReadLine();

                if (boolInput != string.Empty)
                {
                    if ((boolInput == "true") || (boolInput == "TRUE") || (boolInput == "T") || (boolInput == "1") || (boolInput == "True"))
                    {
                        boolList.Add(true);
                    }
                    if (boolInput == "false")
                    {
                        boolList.Add(false);
                    }
                    if (boolInput == "stop")
                    {
                        Console.WriteLine("Stopped input, now showing results: ");
                        isGoing = false;
                    }
                }
                else
                {
                    while (boolInput == string.Empty)
                    {
                        Console.WriteLine("Niks ingevuld, vul een waarde in: ");
                        boolInput = Console.ReadLine();

                        if ((boolInput == "true") || (boolInput == "TRUE"))
                        {
                            boolList.Add(true);
                        }
                        if (boolInput == "false")
                        {
                            boolList.Add(false);
                        }
                        if (boolInput == "stop")
                        {
                            Console.WriteLine("Stopped input, now showing total anmount of trues given: ");
                            isGoing = false;
                        }

                    }
                }

            }

            // Loop through List with foreach.
            int boolAnmount = 0;
            foreach (bool statement in boolList)
            {
                if (statement == true)
                {
                    boolAnmount = boolAnmount + 1;
                }
            }
            Console.WriteLine(boolAnmount);

            Console.ReadKey();
            Console.Clear();


            int[,] array2D = new int[,] { 
                { 15, 12, 10, 8, 9, 8, 5 },
                { 6, 4, -2, -3, -5, -7, -2 },
                { 0, 1, -2, -3, -4, -3, -9 },
                { -11, -8, -5, 2, 4, 5, 1 }
            };

            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                for (int column = 0; column < array2D.GetLength(1); column++)
                {
                    Console.WriteLine(array2D[row, column]);
                }
            }


            Console.ReadKey();  
        }
    }
}
