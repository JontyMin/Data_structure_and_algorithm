namespace _01线性表
{
    public interface IListDs<T>
    {
        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns></returns>
        int GetLength();
        /// <summary>
        /// 清空
        /// </summary>
        void Clear();
        /// <summary>
        /// 是否清空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 新增
        /// </summary>
        void Add(T item);
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        void Insert(T item, int index);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Delete(int index);
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; }
        /// <summary>
        /// 根据索引获取值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T GetItem(int index);
        /// <summary>
        /// 根据值获取索引
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int Locate(T value);
    }
}