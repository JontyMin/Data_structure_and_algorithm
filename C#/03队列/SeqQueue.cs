using System;

namespace _03队列
{
    public class SeqQueue<T>:IQueue<T>
    {
        private T[] data;
        private int count; // 当前元素
        private int front; // 队首
        private int rear; // 队尾

        public SeqQueue(int size)
        {
            this.count = 0;
            this.data=new T[size];
            front = -1;
            rear = -1;
        }

        public SeqQueue():this(10)
        {
            
        }

        public int Count
        {
            get => count;
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }

        public void Enqueue(T item)
        {
            if (count==data.Length)
            {
                Console.WriteLine($"队列已满");
            }
            else
            {
                if (rear==data.Length-1)
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                    count++;
                }
            }
        }

        public T Dequeue()
        {
            if (count>0)
            {
                T temp = data[front + 1];
                front++; // 队首前移
                count--; // 移除
                return temp;
            }
            else
            {
                Console.WriteLine($"队列数据为空");
                return default(T);
            }
        }

        public T Peek()
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++; // 队首前移
                return temp;
            }
            else
            {
                Console.WriteLine($"队列数据为空");
                return default(T);
            }
        }
    }
}