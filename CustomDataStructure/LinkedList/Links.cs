namespace CustomDataStructures
{
    class Link<T>
    {
        /// <summary>Gets the value contained in the node.</summary>
        /// <returns>The value contained in the node.</returns>
        public T Data { get; set; }
        /// <summary>The next link in the <see cref="LinkedList{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedList{T}"/> or null if the current link is the last element in the <see cref="LinkedList{T}"/>.</returns>
        public Link<T> Next { get; set; }
        /// <summary>Initializes a new instance of the <see cref="Link{T}"/> class, containing the specified item.</summary>
        /// <param name="item">The value to contain in the <see cref="Link{T}"/>.</param>
        public Link(T item)
        {
            Data = item;
            Next = null;
        }
    }

    class DoubleLink<T>
    {
        /// <summary>Gets the value contained in the node.</summary>
        /// <returns>The value contained in the node.</returns>
        public T Data { get; set; }
        /// <summary>The next link in the <see cref="LinkedList{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedList{T}"/> or null if the current link is the last element in the <see cref="LinkedList{T}"/>.</returns>
        public Link<T> Next { get; set; }
        /// <summary>The next link in the <see cref="LinkedList{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedList{T}"/> or null if the current link is the first element in the <see cref="LinkedList{T}"/>.</returns>
        public Link<T> Prev { get; set; }
        /// <summary>Initializes a new instance of the <see cref="DoubleLink{T}"/> class, containing the specified item.</summary>
        /// <param name="item">The value to contain in the <see cref="DoubleLink{T}"/>.</param>
        public DoubleLink(T item)
        {
            Data = item;
            Next = Prev = null;
        }
    }
}
