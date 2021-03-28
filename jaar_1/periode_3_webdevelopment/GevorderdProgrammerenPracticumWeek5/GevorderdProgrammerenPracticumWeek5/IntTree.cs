using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class IntTree
    {
        #region Code uit les
        private int item;
        private IntTree left = null;
        private IntTree right = null;

        public IntTree(int item)
        {
            this.item = item;
        }

        public void Add(int item)
        {
            if (item != this.item)
            {
                if (item < this.item)
                    if (left == null)
                        left = new IntTree(item);
                    else
                        left.Add(item);
                else
                    if (right == null)
                    right = new IntTree(item);
                else
                    right.Add(item);
            }
        }

        public bool Search(int item)
        {
            if (item == this.item)
                return true;
            if (item < this.item)
                if (left == null)
                    return false;
                else
                    return left.Search(item);
            else
                if (right == null)
                return false;
            else
                return right.Search(item);
        }
        #endregion


        /// <summary>
        /// Returns min value of tree
        /// </summary>
        /// <returns>Max value</returns>
        public int Min()
        {
            if (left == null)
                return item;
            else
                return left.Min();
        }

        /// <summary>
        /// Returns highest value of tree
        /// </summary>
        /// <returns>Max value</returns>
        public int Max()
        {
            if (right == null)
                return item;
            else
                return right.Max();
        }

        /// <summary>
        /// Counts all elements in tree and returns
        /// </summary>
        /// <returns>Returns count</returns>
        public int Count()
        {
            int result = 1;

            if (left != null)
                result += left.Count();
            if (right != null)
                result += right.Count();

            return result;
        }

        /// <summary>
        /// Starts at smallest value and starts going up from there. Adds to string
        /// </summary>
        /// <returns>String with ordered values</returns>
        public string InOrder()
        {
            if(left == null && right == null)
                return item.ToString();

            if (left != null && right != null)
                return left.InOrder() + " " + item + " " + right.InOrder();

            if (left == null && right != null)
                return item + " " + right.InOrder();
            else
                return left.InOrder() + " " + item;
        }
    }
}
