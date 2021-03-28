using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerenWeek3
{
    class Stack <T>
    {
        private List<T> item = new List<T>();

        public void Push(T item)
        {
            item[] = item;
        }

        public T Pop()
        {
            return item[0];
        }

        public bool isEmpty()
        {
            return item[0] == null ? false : true;
        }
    }
}
