using System;

namespace _01线性表
{
    /// <summary>
    /// 顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeqList<T>:IListDs<T>
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="size">此讯</param>
        public SeqList(int size)
        {
            // 系统的是提供自动扩容，这里直接给定大小：size
            data=new T[size];
            count = 0;
        }
        /// <summary>
        /// 默认构造函数 大小：10
        /// </summary>
        public SeqList():this(10)
        {
            
        }

        /// <summary>
        /// 存储数据
        /// </summary>
        private T[] data;
        /// <summary>
        /// 数据量
        /// </summary>
        private int count = 0;

        /// <summary>
        /// 取数据个数
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        public void Add(T item)
        {
            // 当前数据已满
            if (count == data.Length)
            {
                Console.WriteLine("over full");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        /// <summary>
        /// 插入元素
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index)
        {
            // 如果从前往后遍历 会把后面的给覆盖掉
            //for (int i = index; i < count; i++)
            //{
            //    data[i + 1] = data[i];
            //}
            for (int i = count-1; i >=index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = item;
            count++;
        }
        /// <summary>
        /// 索引删除元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index+1; i < count; i++)
            {
                data[i - 1] = data[i];
            }

            count--;
            return temp;
        }

        public T this[int index]
        {
            get => GetItem(index);
        }

        /// <summary>
        /// 获取元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetItem(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            Console.WriteLine("索引不存在");
            return default(T);
        }

        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }

            // 不存在
            return -1;
        }
    }
}