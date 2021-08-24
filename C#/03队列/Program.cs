using System;
using System.Collections.Generic;

namespace _03队列
{
    class Program
    {
        /*
         * 队列(Queue)是插入操作限定在表的尾部而其它操作限定在表的头部进行的线性表。
         * 把进行插入操作的表尾称为队尾(Rear)，把进行其它操作的头部称为队头(Front)。
         * 当队列中没有数据元素时称为空队列(Empty Queue)。
         * 队列的操作：先进先出(First in First out) FIFO表
         * 后进后出(Last in Last Out)LILO表
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1、使用BCL Queue
            // Queue<int>queue=new Queue<int>();

            // 2、使用SeqQueue
            // IQueue<int>queue=new SeqQueue<int>();

            // 3、使用链队列
            IQueue<int>queue=new LinkQueue<int>();

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


            // 判断是否是回文字符串小案例
            Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            Queue<char> que = new Queue<char>();

            for (int i = 0; i < str.Length; i++)
            {
                // 入栈
                stack.Push(str[i]);

                // 入队
                que.Enqueue(str[i]);
            }

            bool flag = true;

            while (stack.Count>0)
            {
                if (stack.Pop()!= que.Dequeue())
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine($"{str}是否是回文：{flag}");
        }
    }
}
