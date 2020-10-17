namespace _02栈
{
    public interface IStackDs<T>
    {
        int Count { get; }// Get data number

        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns></returns>
        int GetLength();

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        void Clear();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="item"></param>
        void Push(T item);

        T Pop();

        T Peek();
    }
}