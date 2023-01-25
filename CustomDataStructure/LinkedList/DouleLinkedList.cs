using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{

    class DoubleLinkedList<T> : ILinkedList<T, DoubleLink<T>> where T : IComparable
    {
        public int Count { get; private set; }
        public DoubleLink<T> Head { get; private set; }
        public DoubleLink<T> Last { get; private set; }
        public DoubleLinkedList<T> Tail { get; private set; }

        public DoubleLinkedList()
        {
            Count = 0;
            Head = null;
            Last = null;
            Tail = null;
        }

        public void AddFirst(T value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(DoubleLink<T> value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(T value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(DoubleLink<T> value)
        {
            throw new NotImplementedException();
        }

        public void AddBefore(DoubleLink<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddBefore(DoubleLink<T> node, DoubleLink<T> value)
        {
            throw new NotImplementedException();
        }

        public void AddAfter(DoubleLink<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddAfter(DoubleLink<T> node, DoubleLink<T> value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(DoubleLink<T> node)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public DoubleLink<T> Find(T value)
        {
            throw new NotImplementedException();
        }

        public DoubleLink<T> FindLast(T value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(DoubleLink<T> value)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
