using System;
using System.Collections;
using System.Text;

namespace CustomDataStructures
{
    class LinkedList<T> : ILinkedList<T, Link<T>> where T : IComparable
    {
        public int Count { get; private set; }
        public Link<T> Head { get; private set; }
        public Link<T> Last { get; private set; }

        public LinkedList()
        {
            Count = 0;
            Head = null;
            Last = null;
        }

        #region Add
        public void AddFirst(T value)
        {
            Head = new Link<T>(value, Head);

            if (Last == null)
                Last = Head;
        }
        public void AddFirst(Link<T> node)
        {
            node.Next = Head;
            Head = node;

            if (Last == null)
                Last = Head;
        }

        public void AddLast(T value)
        {
            if (Head == null)
                AddFirst(value);
            else
            {
                Last.Next = new Link<T>(value);
                Last = Last.Next;
            }
        }
        public void AddLast(Link<T> node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            if (Head == null)
                AddFirst(node);
            else
            {
                Last.Next = node;
                Last = Last.Next;
            }
        }

        public void AddBefore(Link<T> node, T value)
        {
            if (node == Head)
            {
                AddFirst(value);
                return;
            }

            Link<T> prev = findPrevious(node) ?? throw new InvalidOperationException("Node is not in the current LinkedList.");

            prev.Next = new Link<T>(value, prev.Next);
        }
        public void AddBefore(Link<T> node, Link<T> newNode)
        {
            if (node == Head)
            {
                AddFirst(newNode);
                return;
            }

            Link<T> prev = findPrevious(node) ?? throw new InvalidOperationException("Node is not in the current LinkedList.");

            newNode.Next = prev.Next;
            prev.Next = newNode;
        }

        public void AddAfter(Link<T> node, T value)
        { 
            if (!Contains(node))
                throw new InvalidOperationException("Node is not in the current LinkedList.");

            node.Next = new Link<T>(value, node.Next);
        }
        public void AddAfter(Link<T> node, Link<T> newNode)
        {
            if (!Contains(node))
                throw new InvalidOperationException("Node is not in the current LinkedList.");

            newNode.Next = node.Next;
            node.Next = newNode;
        }
        #endregion

        #region Remove
        public bool Remove(T value)
        {
            Link<T> node = Find(value);
            Remove(Find(value));

            return node != null;
        }

        public void Remove(Link<T> node)
        {
            Link<T> prev = findPrevious(node);
            prev.Next = node.Next;
        }

        public void RemoveFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("LinkedList is empty");
            Head = Head.Next;
        }

        public void RemoveLast()
        {
            Link<T> prev = findPrevious(Last);
            prev.Next = null;
            Last = prev;
        }
        #endregion

        #region Misc
        public bool Contains(Link<T> node)
        {
            if (node == null)
                throw new ArgumentNullException("Node is null.");

            Link<T> temp = Head;
            while (temp != null)
            {
                if (temp == node)
                    return true;
                temp = temp.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            return Find(value) != null;
        }


        public Link<T> Find(T value)
        {
            Link<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                    return temp;
                temp = temp.Next;
            }

            return null;
        }

        public Link<T> FindLast(T value)
        {
            Link<T> temp = Head;
            Link<T> last = null;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                    last = temp;
                temp = temp.Next;
            }

            return last;
        }

        private Link<T> findPrevious(Link<T> node)
        {
            if (node == null)
                throw new ArgumentNullException("Node is null.");

            Link<T> temp = Head;
            while (temp.Next != null)
            {
                if (temp.Next == node)
                    return temp;
                temp = temp.Next;
            }

            return null;
        }

        public void Clear()
        {
            Count = 0;
            Head = null;
            Last = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Link<T> temp = Head;
            while (temp != null)
            { 
                sb.Append(temp.Data);
                sb.Append(" ");
                temp = temp.Next;
            }
            return sb.ToString();
        }
        #endregion
    }

}
