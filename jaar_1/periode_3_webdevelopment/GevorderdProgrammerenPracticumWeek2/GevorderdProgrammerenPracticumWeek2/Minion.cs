using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek2
{
    class Minion
    {
        private string name;
        private string weakness;

        public Minion(string name, string weakness)
        {
            this.name = name;
            this.weakness = weakness;
        }

        public string GetNaam()
        {
            return name;
        }
    }
}
