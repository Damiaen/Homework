using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek1
{
    /// <summary>
    /// Huisdier class
    /// </summary>
    class Huisdier
    {
        private string naam;
        private string soort;

        /// <summary>
        /// Huisdier
        /// </summary>
        /// <param name="naam">Naam van huisdier</param>
        /// <param name="soort">Soort van huisdier</param>
        public Huisdier(string naam, string soort)
        {
            this.naam = naam;
            this.soort = soort;
        }

        /// <summary>
        /// Ophalen van de naam van het dier
        /// </summary>
        /// <returns>Naam van het dier</returns>
        public string GetNaam()
        {
            return naam;
        }

        /// <summary>
        /// Ophalen van de soort van het dier
        /// </summary>
        /// <returns>soort van het dier</returns>
        public string GetSoort()
        {
            return soort;
        }

        /// <summary>
        /// Ophalen van beschrijving van het dier
        /// </summary>
        /// <returns>naam en soort</returns>
        public string GetBeschrijving()
        {
            return $"{naam} {soort}";
        }

    }
}
