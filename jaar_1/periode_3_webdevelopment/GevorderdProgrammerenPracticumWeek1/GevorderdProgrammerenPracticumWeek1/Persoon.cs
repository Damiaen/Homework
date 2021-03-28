using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GevorderdProgrammerenPracticumWeek1
{
    /// <summary>
    /// Persoon class
    /// </summary>
    class Persoon
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private List<Huisdier> huisdieren = new List<Huisdier>();

        /// <summary>
        /// Persoon
        /// </summary>
        /// <param name="voornaam">Voornaam van persoon</param>
        /// <param name="achternaam">Achternaam van persoon</param>
        /// <param name="leeftijd">Leeftijd van persoon</param>
        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
        }

        /// <summary>
        /// Ophalen van naam en voornaam
        /// </summary>
        /// <returns>voor en achternaam als string</returns>
        public string GetNaam()
        {
            return $"{voornaam} {achternaam}";
        }

        /// <summary>
        /// Ophalen van de huisdieren
        /// </summary>
        /// <returns>huisdieren als list</returns>
        public List<Huisdier> GetHuisdieren()
        {
                return huisdieren;
        }

        /// <summary>
        /// Toevoegen van nieuw huisdier
        /// </summary>
        /// <param name="huisdier">Huisdier met naam en soort</param>
        public void AddHuisdier(Huisdier huisdier)
        {
            huisdieren.Add(huisdier);
        }

        /// <summary>
        /// Ophalen van de leeftijd
        /// </summary>
        /// <returns>leeftijd van persoon</returns>
        public int GetLeeftijd()
        {
            return leeftijd;
        }
    }
}
