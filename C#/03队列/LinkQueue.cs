using System;

namespace _03队列
{
    public class LinkQueue<T>:IQueue<T>
    {
        private Node<T> front;// 头节点
        private Node<T> rear;// 尾节点
        private int count;// 元素个数


        public LinkQueue()
        {
            front = rear = null;
            count = 0;
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
            front = rear = null;
            count = 0;
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count==0)
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
            
        }

        public T Dequeue()
        {
            if (count==0)
            {
                Console.WriteLine($"队列为空");
                return default(T);
            }else if (count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                count = 0;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        public T Peek()
        {
            if (front!=null)
            {
                return front.Data;
            }

            return default(T);
        }
    }
}