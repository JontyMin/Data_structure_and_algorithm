using System;
using System.Collections.Generic;

namespace _03队列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1、使用BCL Queue
            Queue<int>queue=new Queue<int>();

            // 入队
            queue.Enqueue(12);
            queue.Enqueue(44);
            queue.Enqueue(23);
            queue.Enqueue(45);
            queue.Enqueue(75);

            Console.WriteLine($"入队列Count:{queue.Count}");

            // 出队 取队首的数据
            var a = queue.Dequeue(); // 先入先出 12
            Console.WriteLine(a);

            Console.WriteLine($"出队列Count:{queue.Count}");

            int b = queue.Peek();
            Console.WriteLine(b);

            Console.WriteLine($"Peek:{queue.Count}");

            queue.Clear();

            Console.WriteLine($"Clear:{queue.Count}");


        }
    }
}
