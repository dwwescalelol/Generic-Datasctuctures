using System;

namespace ZazCollectionGeneric
{
    class Queue<T> where T : IComparable
    {
        private readonly T[] arr;
        private int head, tail;
        /// <summary>Gets the number of elements contained in the <see cref="Queue{T}"/></summary>
        /// <returns>The number of elements contained in the <see cref="Queue{T}"/></returns>
        public int Count { get; private set; }
        /// <summary>Initialises a a new instance of the <see cref="Queue{T}"/> that is empty and has default initial capacity</summary>
        public Queue(int size = 10)
        {
            arr = new T[size];
            head = tail = Count = 0;
        }

        //
        //Queue Checks
        //

        /// <summary>Gets a value indicating if the <see cref="Queue{T}"/> is empty</summary>
        /// <returns><see langword="true"/> if <see cref="Queue{T}"/> is empty, otherwise <see langword="false"/></returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }
        /// <summary>Gets a value indicating if the <see cref="Queue{T}"/> is full</summary>
        /// <returns><see langword="true"/> if <see cref="Queue{T}"/> is full, otherwise <see langword="false"/></returns>
        public bool IsFull()
        {
            return Count == arr.Length;
        }
        /// <summary>Gets a value indicating if a item of type T is present in <see cref="Queue{T}"/></summary>
        /// <returns><see langword="true"/> if item is found in the <see cref="Queue{T}"/>, otherwise <see langword="false"/></returns>
        public bool Contains(T item)
        {
            int i = tail;
            for (int c = 0; c < Count; c++)
            {
                i %= arr.Length;
                if (arr[i].Equals(item))
                    return true;
                i++;
            }
            return false;
        }
        
        //
        //Managing items in queue
        //

        /// <summary>Adds a generic item to the end of the <see cref="Queue{T}"/></summary>
        /// <exception cref="ArgumentOutOfRangeException"> The <see cref="Queue{T}"/> is full </exception>
        public void Enqueue(T item)
        {
            if (IsFull())
                throw new ArgumentOutOfRangeException("Cannot Enqueue on full queue");
            Count++;
            arr[tail++] = item;
            tail %= arr.Length;
        }
        /// <summary>Removes and returns the generic item at the beginning of the <see cref="Queue{T}"/></summary>
        /// <returns>The object that is removed from the beginning of the <see cref="Queue{T}"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"> The <see cref="Queue{T}"/> is empty </exception>
        public T Deqeue()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("Cannot Dequeue on empty queue");
            Count--;
            T temp = arr[head++];
            head %= arr.Length;
            return temp;
        }
        /// <summary>Returns the generic item at the beginning of the <see cref="Queue{T}"/> without removing it</summary>
        /// <returns>The generic item at the beginning of the <see cref="Queue{T}"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">The <see cref="Queue{T}"/> is empty</exception>
        public T Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("Cannot Dequeue on empty queue");
            return arr[tail];
        }

        //
        //Utility
        //

        /// <summary>Removes all items from the <see cref="Queue{T}"/></summary>
        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = default;
            head = tail = Count = 0;
        }
        /// <summary>Coppies an <see cref="Queue{T}"/></summary>
        /// <returns>A new array with all current items in <see cref="Queue{T}"/></returns>
        public T[] ToArray()
        {
            T[] outArr = new T[Count];
            int i = head;
            for (int c = 0; c < Count; c++)
            {
                i %= arr.Length;
                outArr[c] = arr[i];
                i++;
            }
            return outArr;
        }
        /// <summary>Gets the current data of the <see cref="Queue{T}"/> which contains the max size, current count, position of top and the contents</summary>
        /// <returns>The current information of the <see cref="Queue{T}"/></returns>
        public string Info()
        {
            string info = "Max Size: " + arr.Length
                        + "\nCount: " + Count
                        + "\nTail: " + tail + ", Head: " + head 
                        + "\nContents:\n";
            for (int i = 0; i < arr.Length; i++)
            {
                info += i + ": " + arr[i].ToString();
                if (i == head && i == tail)
                    info += " <--Head--><--Tail-->\n";
                else if (i == head)
                    info += " <--Head-->\n";
                else if (i == tail)
                    info += " <--Tail-->\n";
                else
                    info += "\n";
            }
            return info;
        }


    }
}
