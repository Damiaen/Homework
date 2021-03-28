using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek2
{
    class Person
    {
        private string name;
        private int evilness;

        public Person(string name, int evilness)
        {
            this.name = name;
            this.evilness = evilness;
        }

        public string GetName()
        {
            return name;
        }

        public int getEvilness()
        {
            return evilness;
        }

    }
}
