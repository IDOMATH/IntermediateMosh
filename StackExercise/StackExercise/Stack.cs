using System;
using System.Collections;

namespace StackExercise
{
    public class Stack
    {
        // ArrayList to store any object added to Stack.
        private readonly ArrayList List = new ArrayList();

        // Methods are Push(object), Pop(), Clear().

        // Push method to add to top of stack
        public void Push(object obj)
        {
            // Check that object is not null reference
            if (obj == null) throw new InvalidOperationException("Cannot add null to the stack");
            else
            {
                List.Add(obj);
                Console.WriteLine("Added {0} to the stack", obj);
            }
        }

        // Pop method to get top of stack
        public object Pop()
        {
            if (List.Count == 0) throw new InvalidOperationException("Stack is empty, nothing to Pop");
            else
            {
                int topOfStack = List.Count - 1;
                var value = List[topOfStack];
                List.RemoveAt(topOfStack);
                return value;
            }
        }

        // Clear method to empty stack
        public void Clear()
        {
            List.Clear();
        }
    }
}
