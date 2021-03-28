using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren_2
{
    /// <summary>
    /// Minion
    /// </summary>
    class Minion : Person
    {
        private string weakness;

        /// <summary>
        /// Zwakheid van de minion
        /// </summary>
        /// <param name="name">Naam van de minion</param>
        /// <param name="weakness">Naam van de weakness</param>
        public Minion(string name, string weakness) : base(50)
        {
            this.name = name;
            this.weakness = weakness;
      
        }

        /// <summary>
        /// Geeft de zwakte van de minion
        /// </summary>
        /// <returns>Zwakte</returns>
        public string GetWeakness()
        {
            return weakness;
        }
    }
}
