using System;
using System.Collections.Generic;
using System.Text;

namespace _02栈
{
    class Node<T>
    {
        private T data;
        private Node<T> next;


        public T Data
        {
            get => data;
            set => data = value;
        }

        public Node<T> Next
        {
            get => next;
            set => next = value;
        }

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public Node(Node<T>next)
        {
            data = default(T);
            this.next = next;
        }

        public Node(T data,Node<T>next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
