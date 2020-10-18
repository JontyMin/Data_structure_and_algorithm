namespace _03队列
{
    public interface IQueue<T>
    {
        int Count { get; }

        int GetLength();

        bool IsEmpty();

        void Clear();

        void Enqueue(T item);

        T Dequeue();

        T Peek();

    }
}