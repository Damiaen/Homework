using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren_2
{
    /// <summary>
    /// Villain
    /// </summary>
    class Villain : Person
    {                 
        private List<Minion> minions = new List<Minion>();
        private List<string> strengths = new List<string>();

        /// <summary>
        /// Villain
        /// </summary>
        /// <param name="name">Naam van de villain</param>
        /// <param name="evilness">Evilness van de villain</param>
        public Villain(string name, int evilness) : base(evilness)
        {
            this.name = name;
        }

        /// <summary>
        /// Lijst met alle minions van de villain
        /// </summary>
        /// <returns>Lijst met minions</returns>
        public List<Minion> GetMinions()
        {
            return minions;
        }

        /// <summary>
        /// Voegt minion toe aan de lijst van de villain    
        /// </summary>
        /// <param name="minion"></param>
        public void AddMinion(Minion minion)
        {
            minions.Add(minion);
        }
    }
}
