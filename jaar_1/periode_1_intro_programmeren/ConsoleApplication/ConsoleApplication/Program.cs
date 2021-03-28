using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variables */

            char variable1 = 'C';
            int nummer1 = 123;
            double nummer2 = 1.5;
            bool status = false;
            string name = "Damiaen";
               
            double rest = Convert.ToDouble(nummer1) % nummer2;

            /* Hello world log */
            Console.WriteLine("Hello "+ name);

            /* Logging Variables */
            Console.WriteLine("Char: " + variable1);
            Console.WriteLine("Int: " + nummer1);
            Console.WriteLine("Double: " + nummer2);
            Console.WriteLine("Status: " + status);

            /* Calculate rest of nummer1 and nummer2 */

            //rest = (Convert.ToDouble(nummer1)  % nummer2);
            Console.WriteLine("Remainder is: " + rest);

            Console.ReadKey();
            Console.Clear();

            /* Opdracht C temperatuur */
            int temperatuur;
            double temperatuurFahrenheit;

            Console.WriteLine("Geef temperatuur in graden celsius: ");
            temperatuur = Convert.ToInt32(Console.ReadLine());
            temperatuurFahrenheit = (temperatuur * 1.8) + 32;
            Console.WriteLine("Ingevoerde temperatuur in celsius: " + temperatuur);
            Console.WriteLine("Ingevoerde temperatuur omgerekend naar Fahrenheit: " + temperatuurFahrenheit);

            Console.ReadKey();
            Console.Clear();

            /* Opdracht C valuta */
            int euro;
            double calculatedValuta;

            Console.WriteLine("Voer aantal euros in dat omgerekent moet worden naar dollars");
            euro = Convert.ToInt32(Console.ReadLine());
            calculatedValuta = euro * 1.16;

            Console.WriteLine(euro + " euro is " + calculatedValuta + " dollar.");

            Console.ReadKey();
            Console.Clear();

            /* Opdracht D */

            string gender;
            double height;
            double wristwidth;
            double result;
            string lang;

            string goodbyeDutch = "Tot ziens!";
            string goodbyeEnglish = "Goodbye!";
            string goodbyeFrench = "Au Revoir!";
            string goodbyeGerman = "Auf Wiedersehen!";
            string goodbyeSpanish = "Adios!";


            Console.WriteLine("Voer uw moedertaal in (Nederlands, Engels, Frans, Duits, Spaans): ");
            lang = Console.ReadLine();

            Console.WriteLine("Voer geslacht in (man/vrouw)");
            gender = Console.ReadLine();

            /* Checks chosen gender */
            if (gender.Contains("man"))
            {
                Console.WriteLine("Voer aub uw lengte in: ");
                height = Convert.ToDouble(Console.ReadLine());
                result = (height - 100) * 0.9;
                Console.WriteLine("Uw ideale gewicht is: "+result+" kg.");


            } else if (gender.Contains("vrouw"))
            {
                Console.WriteLine("Voer aub uw lengte in: ");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Voer aub uw polsomtrek in: ");
                wristwidth = Convert.ToDouble(Console.ReadLine());

                result = ((height + 4 * wristwidth) - 100) / 2;
                Console.WriteLine("Uw ideale gewicht is: " + result + " kg.");
            } else
            {
                Console.WriteLine("Fout bij invullen geslacht");
            }

            /* Goodbye message */   
            if (lang != "")
            {
                if (lang.Contains("Engels"))
                {
                    Console.WriteLine(goodbyeEnglish);
                }
                if (lang.Contains("Nederlands"))
                {
                    Console.WriteLine(goodbyeDutch);
                }
                if (lang.Contains("Duits"))
                {
                    Console.WriteLine(goodbyeDutch);
                }
                if (lang.Contains("Frans"))
                {
                    Console.WriteLine(goodbyeFrench);
                }
                if (lang.Contains("Spaans"))
                {
                    Console.WriteLine(goodbyeSpanish);
                } 

            } else
            {
                Console.WriteLine("No language specified, goodbye!");
            }
            
            Console.ReadKey();


        }
    }
}
