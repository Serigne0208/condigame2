using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodinGame.En_Cours
{
    class _66_MyStack
    {
        //Keep these two fields as they are
        private Object[] elements;
        private int size = 0;

        public _66_MyStack(int initialCapacity)
        {
            //elements = new Object[initialCapacity];
        }

        public void Push(object o)
        {
            size++;
            elements = new object[] { o };
            EnsureCapacity();

        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return elements[elements.Count() - 1];
        }

        private void EnsureCapacity()
        {
            if (elements.Length == size)
            {
                Object[] old = elements;
                elements = new Object[2 * size + 1];
                old.CopyTo(elements, 0);
            }
        }
    }
}
