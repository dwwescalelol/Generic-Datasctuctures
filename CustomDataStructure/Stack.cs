using System;

namespace CustomDataStructures
{
    class Stack<T> where T : IComparable
    {
        private readonly T[] arr;
        private int top;
        /// <summary>Gets the number of elements in the <see cref="Stack{T}"/>.</summary>
        /// <returns>The number of elements in the <see cref="Stack{T}"/>.</returns>
        public int Count { get { return top; }}
        /// <summary>Initialises a new instance of the <see cref="Stack{T}"/> that is empty and has default capacity of 10.</summary>
        public Stack()
        {
            arr = new T[10];
            top = 0;
        }
        /// <summary> Initialises a new instance of the <see cref="Stack{T}"/> that is empty and has variable capacity.</summary>
        /// <param name="capacity">The number of elements the <see cref="Stack{T}"/> can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">Capacity is less than 0.</exception>
        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));
            arr = new T[capacity];
            top = 0;
        }

        //
        //Stack Checks
        //

        /// <summary>Gets a value indicating if the <see cref="Stack{T}"/> is empty.</summary>
        /// <returns><see langword="true"/> if <see cref="Stack{T}"/> is empty, otherwise <see langword="false"/>.</returns>
        public bool IsEmpty()
        {
            return top == 0;
        }
        /// <summary>Gets a value indicating if the <see cref="Stack{T}"/> is full.</summary>
        /// <returns><see langword="true"/> if <see cref="Stack{T}"/> is full, otherwise <see langword="false"/>.</returns>
        public bool IsFull()
        {
            return top == arr.Length;
        }
        /// <summary>Gets a value indicating if a <see cref="T"/> item is present in <see cref="Stack{T}"/>.</summary>
        /// <param name="item">The <see cref="T"/> item to locate in the <see cref="Stack{T}"/>. The value can be <see langword="null"/>.</param>
        /// <param name="startIndex">The index to start locating the <see cref="T"/> item.</param>
        /// <returns><see langword="true"/> if item is found in the <see cref="Stack{T}"/>, otherwise <see langword="false"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException"> The startIndex is out of bounds of the stack.</exception>
        public bool Contains(T item, int startIndex = 0)
        {
            if (startIndex < 0 || startIndex >= top)
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            for (int i = startIndex; i < top; i++)
                if (arr[i].Equals(item))
                    return true;
            return false;
        }

        //
        //Managing items in array
        //

        /// <summary>Inserts <see cref="T"/> item at the top of the <see cref="Stack{T}"/>.</summary>
        /// <param name="item">The <see cref="T"/> item to push onto the top of the <see cref="Stack{T}"/>. The value can be <see langword="null"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException"> The Stack is full.</exception>
        public void Push(T item)
        {
            if (IsFull())
                throw new ArgumentOutOfRangeException(nameof(top));
            arr[top] = item;
            top++;
        }
        /// <summary>Removes and returns the <see cref="T"/> item at the top of the <see cref="Stack{T}"/>.</summary>
        /// <returns>The <see cref="T"/> item removed from the top of the <see cref="Stack{T}"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The Stack is empty.</exception>
        public T Pop()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException(nameof(top));
            return arr[--top];
        }
        /// <summary>Returns the <see cref="T"/> item at the top of the <see cref="Stack{T}"/> without removing it.</summary>
        /// <returns>The <see cref="T"/> item a the top of the <see cref="Stack{T}"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The Stack is empty.</exception>
        public T Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException(nameof(top));
            return arr[top - 1];
        }

        //
        //Utility
        //

        /// <summary>Removes all items from the <see cref="Stack{T}"/> and sets all values to <see langword="default"/>.</summary>
        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = default;
            top = 0;
        }
        /// <summary>Coppies the <see cref="Stack{T}"/> to a new array.</summary>
        /// <returns>A new array with all current items in <see cref="Stack{T}"/>.</returns>
        public T[] ToArray()
        {
            T[] outArr = new T[top];
            for (int i = 0; i < top; i++)
                outArr[i] = arr[i];
            return outArr;
        }
        /// <summary>Gets the current data of the <see cref="Stack{T}"/> which contains the max size, count, position of top and the contents.</summary>
        /// <returns>The current information of the <see cref="Stack{T}"/>.</returns>
        public string Info()
        {
            string info = "Max Size: " + arr.Length 
                        + "\nCount: " + Count
                        + "\nTop: " + top 
                        + "\nContents:\n";
            for (int i = 0; i < arr.Length; i++)
            {
                info += i + ": " + arr[i].ToString();
                if (i == top )
                    info += " <--Top-->\n";
                else
                    info += "\n";
            }
            return info;
        }
    }
}
