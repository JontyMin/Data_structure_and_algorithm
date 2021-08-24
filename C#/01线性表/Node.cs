namespace _01线性表
{
    /// <summary>
    /// 单链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        // 存储的数据
        private T data;

        // 指针 指向下一条数据
        private Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T value)
        {
            data = value;
            next = null;
        }

        public Node(T value,Node<T>next)
        {
            this.data = value;
            this.next = next;
        }

        public Node(Node<T>next)
        {
            this.next = next;
        }


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
    }
}