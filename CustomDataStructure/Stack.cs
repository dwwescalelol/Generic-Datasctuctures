using System;

namespace ZazCollectionGeneric
{
    class Stack<T> where T : IComparable
    {
        private readonly T[] arr;
        private int top;
        /// <summary>Initialises a new instance of the <see cref="Stack{T}"/> that is empty and has default initial capacity</summary>
        public Stack(int size = 10)
        {
            arr = new T[size];
            top = 0;
        }

        //
        //Stack Checks
        //

        /// <summary>Gets a value indicating if the <see cref="Stack{T}"/> is empty</summary>
        /// <returns><see langword="true"/> if <see cref="Stack{T}"/> is empty, otherwise <see langword="false"/></returns>
        public bool IsEmpty()
        {
            return top == 0;
        }
        /// <summary>Gets a value indicating if the <see cref="Stack{T}"/> is full</summary>
        /// <returns><see langword="true"/> if <see cref="Stack{T}"/> is full, otherwise <see langword="false"/></returns>
        public bool IsFull()
        {
            return top == arr.Length;
        }
        /// <summary>Gets a value indicating if a item of type T is present in <see cref="Stack{T}"/></summary>
        /// <returns><see langword="true"/> if item is found in the <see cref="Stack{T}"/>, otherwise <see langword="false"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"> The startIndex is out of bounds of the stack</exception>
        public bool Contains(T item, uint startIndex = 0)
        {
            if (startIndex >= top)
                throw new ArgumentOutOfRangeException("startIndex out of bound of stack");
            for (uint i = startIndex; i < top; i++)
                if (arr[i].Equals(item))
                    return true;
            return false;
        }

        //
        //Managing items in array
        //

        /// <summary>Inserts a generic item at the top of the <see cref="Stack{T}"/></summary>
        /// <exception cref="ArgumentOutOfRangeException"> The Stack is full </exception>
        public void Push(T item)
        {
            if (IsFull())
                throw new ArgumentOutOfRangeException("Cannot Push on full stack");
            arr[top] = item;
            top++;
        }
        /// <summary>Removes and returns the generic item at the top of the <see cref="Stack{T}"/></summary>
        /// <returns>The generic item removed from the top of the <see cref="Stack{T}"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"> The Stack is empty </exception>
        public T Pop()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("Cannot Pop on empty stack");
            return arr[--top];
        }
        /// <summary>Returns a generic item at the top of the <see cref="Stack{T}"/></summary>
        /// <returns>The generic item a the top of the <see cref="Stack{T}"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"> The Stack is empty </exception>
        public T Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("Cannot Peek on empty stack");
            return arr[top - 1];
        }

        //
        //Utility
        //

        /// <summary>Removes all items from the <see cref="Stack{T}"/></summary>
        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = default;
            top = 0;
        }
        /// <summary>Coppies an <see cref="Stack{T}"/></summary>
        /// <returns>A new array with all current items in <see cref="Stack{T}"/></returns>
        public T[] ToArray()
        {
            T[] outArr = new T[top];
            for (int i = 0; i < top; i++)
                outArr[i] = arr[i];
            return outArr;
        }
        /// <summary>Gets the number of elements in the <see cref="Stack{T}"/></summary>
        /// <returns>The number of elements in the <see cref="Stack{T}"/></returns>
        public int Count()
        {
            return top;
        }
        /// <summary>Gets the current data of the <see cref="Stack{T}"/> which contains the max size, position of top and the contents</summary>
        /// <returns>The current information of the <see cref="Stack{T}"/></returns>
        public string Info()
        {
            string info = "Max Size: " + arr.Length + "\nTop: " + top + "\nContents:\n";
            for (int i = 0; i < arr.Length; i++)
            {
                info += i + ": " + arr[i].ToString();
                if (i == top - 1)
                    info += " <--Top-->\n";
                else
                    info += "\n";
            }
            return info;
        }
    }
}
