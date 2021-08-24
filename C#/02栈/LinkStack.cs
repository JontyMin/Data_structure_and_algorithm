namespace _02栈
{
    public class LinkStack<T>:IStackDs<T>
    {
        private Node<T> top;// 栈顶元素节点
        private int count = 0;// 栈中元素个数

        /// <summary>
        /// 获取栈中元素个数
        /// </summary>
        public int Count
        {
            get => count;
        }
        /// <summary>
        /// 获取栈中元素的个数
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return count;
        }
        /// <summary>
        /// 栈元素是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// 清空栈元素
        /// </summary>
        public void Clear()
        {
            count = 0;
            top = null;
        }
        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            // 把新添加的元素作为栈顶元素 头节点
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
        /// <summary>
        /// 获取栈顶元素并删除 出栈
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        /// <summary>
        /// 获取栈顶元素 不删除
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return top.Data;
        }
    }
}