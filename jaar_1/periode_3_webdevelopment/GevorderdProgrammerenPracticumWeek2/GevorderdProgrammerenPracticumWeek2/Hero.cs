using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek2
{
    class Hero
    {

        private List<Villain> archnemesis = new List<Villain>();

        public Hero(string name, Villain nemesis)
        {
            this.name = name;
            this.archnemesis = nemesis;
        }

        public GetArchnemesis()
        {
            return archnemesis;
        }
    }
}
