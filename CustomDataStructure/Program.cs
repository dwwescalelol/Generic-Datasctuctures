using System;
using System.Collections;

namespace ZazCollectionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> test = new Stack<int>(10);
            Queue<int> queue = new Queue<int>(20);
            Stack ajusd = new Stack(1);
            Queue queueSys = new Queue(1);
            ajusd.Push(4);
            ajusd.Push(4);

            try
            {
                test.Push(3);
                test.Push(5);
                Console.WriteLine(test.Peek());
                Console.WriteLine(test.Info());
                Console.WriteLine(test.Pop());
                test.Contains(2);
                Console.WriteLine(test.Pop());
                Console.WriteLine(test.Peek());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
