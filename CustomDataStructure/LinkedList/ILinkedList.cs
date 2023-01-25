using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    internal interface ILinkedList<T, L> where T : IComparable where L : ILink<T>
    {
        public void AddFirst(T value);
        public void AddFirst(L value);
        public void AddLast(T value);
        public void AddLast(L value);
        public void AddBefore(L node, T value);
        public void AddBefore(L node, L value);
        public void AddAfter(L node, T value);
        public void AddAfter(L node, L value);
        
        public bool Contains(L node);
        public bool Contains(T value);

        public L Find(T value);
        public L FindLast(T value);
        
        public bool Remove(T value);
        public void Remove(L value);
        public void RemoveFirst();
        public void RemoveLast();

        public void Clear();
        public string ToString();
    }
}
