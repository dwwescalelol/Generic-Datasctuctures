using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    class Link<T> : ILink<T>
    {
        /// <summary>Gets the value contained in the node.</summary>
        /// <returns>The value contained in the node.</returns>
        public T Data { get; set; }
        /// <summary>The next link in the <see cref="LinkedLists{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedLists{T}"/> or null if the current link is the last element in the <see cref="LinkedLists{T}"/>.</returns>
        public Link<T> Next { get; set; }
        /// <summary>Initializes a new instance of the <see cref="Link{T}"/> class, containing the specified item.</summary>
        /// <param name="item">The value to contain in the <see cref="Link{T}"/>.</param>
        public Link(T item)
        {
            Data = item;
            Next = null;
        }

        public Link(T item, Link<T> next)
        {
            Data = item;
            Next = next;
        }
    }
}
