using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Programmeren_2
{
    /// <summary>
    /// Hero
    /// </summary>
    class Hero : Person, Ihasstrengths
    {
        private Villain archnemesis;
        private Person sidekick;
        private List<string> strengths = new List<string>();

        /// <summary>
        /// Hero contructor
        /// </summary>
        /// <param name="name">Naam van de hero</param>
        /// <param name="archnemesis">Archnememsis van de hero</param>
        /// <param name="sidekick">Sidekick van de hero</param>
        /// <param name="evilness">Evilness van de hero</param>
        public Hero(string name, Villain archnemesis, Person sidekick, int evilness): base(evilness)
        {
            this.name = name;
            this.archnemesis = archnemesis;
            this.sidekick = sidekick;
        }

        /// <summary>
        /// Hero contructor
        /// </summary>
        /// <param name="name">Naam van de hero</param>
        /// <param name="archnemesis">Archnememsis van de hero</param>
        /// <param name="evilness">Evilness van de hero</param>
        public Hero(string name, Villain archnemesis, int evilness) : base(evilness)
        {
            this.name = name;
            this.archnemesis = archnemesis;
        }

        /// <summary>
        /// Voegt een strength toe aan de hero
        /// </summary>
        /// <param name="strength">Strength</param>
        public void AddStrength(string strength)
        {
            strengths.Add(strength);
        }

        /// <summary>
        /// Geeft een lijst met strengths van de hero
        /// </summary>
        /// <returns>Lijst met strengths</returns>
        public List<string> GetStrengths()
        {
            return strengths;
        }

        /// <summary>
        /// Geeft de aardsvijand van de hero
        /// </summary>
        /// <returns>Aardsvijand</returns>
        public Villain GetArchnemesis()
        {
            return archnemesis;
        }

        /// <summary>
        /// Geeft de sidekick vand de hero
        /// </summary>
        /// <returns>Sidekick</returns>
        public Person GetSidekick()
        {
            return sidekick;
        }
        
        /// <summary>
        /// Update de sidekick van de hero
        /// </summary>
        /// <param name="sidekick">nieuwe sidekick</param>
        public void UpdateSidekick(Person sidekick)
        {
            this.sidekick = sidekick;
        }
    }
}
