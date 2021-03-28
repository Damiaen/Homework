using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class PersonTree
    {
        #region given code
        private Person person;
        private PersonTree lessEvil;
        private PersonTree moreEvil;

        public PersonTree(Person p)
        {
            person = p;
        }

        public string GetPersonName()
        {
            return person.GetName();
        }

        public string GetMostEvilPerson()
        {
            if (moreEvil == null)
                return person.GetName();
            else
                return moreEvil.GetMostEvilPerson();
        }
        #endregion

        /// <summary>
        /// Adds person to persontree
        /// </summary>
        /// <param name="p">person</param>
        public void Add(Person p)
        {
            if (p.IsMoreEvil(person))
            {
                if (moreEvil == null)
                    moreEvil = new PersonTree(p);
                else
                    moreEvil.Add(p);
                return;
            }

            if (lessEvil == null)
                lessEvil = new PersonTree(p);
            else
                lessEvil.Add(p);
        }

        /// <summary>
        /// return names of persons in the tree sorted from good to evil
        /// </summary>
        /// <returns>names of persons in the tree sorted from good to evil</returns>
        public string GetAllNamesSorted()
        {
            if (lessEvil == null && moreEvil == null)
                return person.GetName();

            if (lessEvil != null && moreEvil != null)
                return $"{lessEvil.GetAllNamesSorted()} - {person.GetName()} - {moreEvil.GetAllNamesSorted()}";

            return lessEvil == null ?
                $"{person.GetName()} - {moreEvil.GetAllNamesSorted()}" :
                $"{lessEvil.GetAllNamesSorted()} - {person.GetName()}";
        }
    }
}
