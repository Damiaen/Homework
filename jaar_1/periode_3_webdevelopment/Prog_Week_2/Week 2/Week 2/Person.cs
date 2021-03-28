using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren_2
{
    /// <summary>
    /// Persoon
    /// </summary>
    abstract class Person
    {
        protected string name;
        private int evilness;

        public Person(int evilness)
        {
            if (evilness >= 0 && evilness <= 100)
            {
                this.evilness = evilness;
            }
            else
            {
                this.evilness = 50;
            }
        }

        /// <summary>
        /// Geeft de naam van het persoon
        /// </summary>
        /// <returns>Naam van het persoon</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Geeft de evilness van het persoon
        /// </summary>
        /// <returns>Evilness</returns>
        public int GetEvilness()
        {
            return evilness;
        }
    }
}
