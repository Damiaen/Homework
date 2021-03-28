using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Geef je invoer: ");
            string input = Console.ReadLine();
            #region code opdracht A
            string tekst = Convert.ToString(input);
            // p.MiddelsteLetter(tekst);
            int indexInt = Convert.ToInt32(Console.ReadLine());
            p.LetterOpIndex(tekst, indexInt);
            //hier komt de code voor opdrachten 4 en 5
            #endregion
            Console.ReadKey();
        }
        /// <summary>
        /// Returns middle character of string
        /// </summary>
        /// <param name="tekst">user input tekst</param>
        /// <returns>middle characters</returns>
        public string MiddelsteLetter(string tekst)
        {
            string trimmed = string.Empty;
            var mid = tekst.Length;

            int midCharIndex = (tekst.Length / 2);
            if ((tekst.Length) % 2 != 0)
            {
                trimmed = tekst.Substring(midCharIndex, 1);
            }
            else
            {
                trimmed = tekst.Substring(midCharIndex - 1, 2); ;
            }
            //Console.WriteLine(mid);
            Console.WriteLine(trimmed);
            return trimmed;
            //hier komt de code voor opdrachten 4 en 6  
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tekst"></param>
        /// <param name="index"></param>
        /// <returns>Value</returns>
        public string LetterOpIndex(string tekst, int index)
        {
            if (index > tekst.Length || index < 0)
            {
                Console.WriteLine("ERROR");
                return tekst;
            } else
            {
                string trimmedTekst = tekst.Substring(index, tekst.Length - index);

                Console.WriteLine(tekst.Length);
                Console.WriteLine(trimmedTekst);
                return trimmedTekst;
            }

        }

        public void AantalWoorden(string tekst)
        {


        }
    }
}
