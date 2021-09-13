namespace 动态数组
{
    /// <summary>
    /// 动态数组接口 Dynamic Array
    /// </summary>
    public interface IArrayList<T>
    {
        int Size();

        bool IsEmpty();

        bool Contains(T element);

        void Add(T element);

        void Add(T element,int index);

        T Remove(int index);

        void Clear();

        void Set(T element);

        void Set(T element, int index);

        T Get(int index);
        
        int IndexOf(T element);
    }
}