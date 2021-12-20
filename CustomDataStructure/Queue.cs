using System;

namespace CustomDataStructures
{
    class Queue<T> where T : IComparable
    {
        private readonly T[] arr;
        private int head, tail;
        /// <summary>Gets the number of elements contained in the <see cref="Queue{T}"/>.</summary>
        /// <returns>The number of elements contained in the <see cref="Queue{T}"/>.</returns>
        public int Count { get; private set; }
        /// <summary>Initialises a new instance of the <see cref="Queue{T}"/> that is empty and has default capacity of 10.</summary>
        public Queue()
        {
            arr = new T[10];
            head = tail = Count = 0;
        }
        /// <summary> Initialises a new instance of the <see cref="Queue{T}"/> that is empty and has variable capacity.</summary>
        /// <param name="capacity">The number of elements the <see cref="Queue{T}"/> can contain.</param>
        /// <exception cref="ArgumentOutOfRangeException">Capacity is less than 0.</exception>
        public Queue(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));
            arr = new T[capacity];
            head = tail = Count = 0;
        }
        //
        //Queue Checks
        //

        /// <summary>Gets a value indicating if the <see cref="Queue{T}"/> is empty.</summary>
        /// <returns><see langword="true"/> if <see cref="Queue{T}"/> is empty, otherwise <see langword="false"/>.</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }
        /// <summary>Gets a value indicating if the <see cref="Queue{T}"/> is full.</summary>
        /// <returns><see langword="true"/> if <see cref="Queue{T}"/> is full, otherwise <see langword="false"/>.</returns>
        public bool IsFull()
        {
            return Count == arr.Length;
        }
        /// <summary>Gets a value indicating if a <see cref="T"/> item is present in <see cref="Queue{T}"/>.</summary>
        /// <param name="item">The <see cref="T"/> item to locate in the <see cref="Queue{T}"/>. The value can be <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if item is found in the <see cref="Queue{T}"/>, otherwise <see langword="false"/>.</returns>
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

        /// <summary>Inserts <see cref="T"/> item at the tail of the <see cref="Queue{T}"/>.</summary>
        /// <param name="item">The <see cref="T"/> item to enqueue onto the tail of the <see cref="Queue{T}"/>. The value can be <see langword="null"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException"> The Queue is full.</exception>
        public void Enqueue(T item)
        {
            if (IsFull())
                throw new ArgumentOutOfRangeException(nameof(Count));
            Count++;
            arr[tail++] = item;
            tail %= arr.Length;
        }
        /// <summary>Removes and returns the <see cref="T"/> item at the head of the <see cref="Queue{T}"/>.</summary>
        /// <returns>The <see cref="T"/> item removed from the head of the <see cref="Queue{T}"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The Queue is empty.</exception>
        public T Deqeue()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException(nameof(Count));
            Count--;
            T temp = arr[head++];
            head %= arr.Length;
            return temp;
        }
        /// <summary>Returns the <see cref="T"/> item at the head of the <see cref="Queue{T}"/> without removing it.</summary>
        /// <returns>The <see cref="T"/> item a the head of the <see cref="Queue{T}"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The Queue is empty.</exception>
        public T Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException(nameof(Count));
            return arr[head];
        }

        //
        //Utility
        //

        /// <summary>Removes all items from the <see cref="Queue{T}"/> and sets all values to <see langword="default"/>.</summary>
        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = default;
            head = tail = Count = 0;
        }
        /// <summary>Coppies an <see cref="Queue{T}"/> to a new array.</summary>
        /// <returns>A new array with all current items in <see cref="Queue{T}"/>.</returns>
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
        /// <summary>Gets the current data of the <see cref="Queue{T}"/> which contains the max size, current count, position of head and tail, and the contents.</summary>
        /// <returns>The current information of the <see cref="Queue{T}"/>.</returns>
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
