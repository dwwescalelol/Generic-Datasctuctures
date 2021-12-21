using System;
using System.Collections;


namespace CustomDataStructures
{
    class LinkedList<T> where T : IComparable
    {
        #region Members and Constructor
        public int Count { get; private set; }
        public Link<T> Head { get; private set; }
        public LinkedList<T> Tail { get; private set; }
        public Link<T> Last { get; private set; }

        public LinkedList()
        {
            Head = Last = null;
            Tail = null;
            Count = 0;
        }
        #endregion

        #region Edit LinkedList

        public void AddFirst(T item)
        {
            Head = new Link<T>(item);
        }
        public void AddFirst(Link<T> link)
        {
            Head = link ?? throw new ArgumentNullException(nameof(link));
        }

        #endregion
    }
}
