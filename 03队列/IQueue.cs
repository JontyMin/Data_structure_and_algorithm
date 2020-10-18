namespace _03队列
{
    public interface IQueue<T>
    {
        int Count { get; }

        int GetLength();

        bool IsEmpty();

        void Clear();

        void EnQueue(T item);

        T DeQueue();

        T Peek();

    }
}