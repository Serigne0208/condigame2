using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.A_Tester
{
    public class MyStack1
    {

        class MyStack
        {
            // keep these two fields as they are
            private Object[] elements;
            private int size = 0;

            public MyStack(int initialCapacity)
            {
                elements = new Object[initialCapacity];
            }

            public void Push(object o)
            {
                EnsureCapacity();
                elements[size++] = o;  // Increment size after assigning the object
            }

            public object Pop()
            {
                if (size == 0)
                {
                    throw new InvalidOperationException();
                }

                object topElement = elements[--size];  // Decrement size before accessing the element
                elements[size] = null;  // Eliminate obsolete reference to prevent memory leak
                return topElement;
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
}
