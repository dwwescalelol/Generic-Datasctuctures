namespace CustomDataStructures
{
  class DoubleLink<T> : ILink<T>
    {
        /// <summary>Gets the value contained in the node.</summary>
        /// <returns>The value contained in the node.</returns>
        public T Data { get; set; }
        /// <summary>The next link in the <see cref="LinkedLists{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedLists{T}"/> or null if the current link is the last element in the <see cref="LinkedLists{T}"/>.</returns>
        public DoubleLink<T> Next { get; set; }
        /// <summary>The next link in the <see cref="LinkedLists{T}"/>.</summary>
        /// <returns>The next link in the <see cref="LinkedLists{T}"/> or null if the current link is the first element in the <see cref="LinkedLists{T}"/>.</returns>
        public DoubleLink<T> Prev { get; set; }
        /// <summary>Initializes a new instance of the <see cref="DoubleLink{T}"/> class, containing the specified item.</summary>
        /// <param name="item">The value to contain in the <see cref="DoubleLink{T}"/>.</param>
        public DoubleLink(T item, DoubleLink<T> next)
        {
            Data = item;
            Next = next;
            Prev = null;
        }
    }
}
