using System;
using System.ComponentModel.Design;
using System.Text;

namespace 动态数组
{
    public class ArrayList<T>:IArrayList<T>
    {
        /// <summary>
        /// 默认长度
        /// </summary>
        private const int DEFAULT = 10;

        /// <summary>
        /// 数量
        /// </summary>
        private int size;

        /// <summary>
        /// 所有元素
        /// </summary>
        private T[] arrs;

        public ArrayList(T[] arrs)
        {
            this.arrs = arrs;
        }

        public ArrayList(int capaticy)
        {
            capaticy = capaticy < DEFAULT ? DEFAULT : capaticy;
            arrs = new T[capaticy];
        }

        /// <summary>
        /// this 调用构造函数
        /// 默认选择参数最匹配
        /// </summary>
        public ArrayList():this(DEFAULT)
        {

        }

        /// <summary>
        /// 获取长度
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// 是否包含
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            return IndexOf(element) > -1;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            arrs[size++] = element;
        }

        /// <summary>
        /// 根据下标添加
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        public void Add(T element, int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }

            for (var i = size; i >= index; i--)
            {
                arrs[i + 1] = arrs[i];
            }

            arrs[index] = element;

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return default(T);
            }

            var oldElement=arrs[index];
            for (var i = index + 1; i < size; i++)
            {
                // 元素前移
                arrs[i - 1] = arrs[i];
            }

            arrs[--size] = default(T);
            return oldElement;
        }

        /// <summary>
        /// 清除所有元素
        /// </summary>
        public void Clear()
        {
            // 如果空间比较小可以直接赋0 节省时间
            // 反之则可以 置空arrs
            size = 0;
        }

        public void Set(T element)
        {
            throw new System.NotImplementedException();
        }

        public void Set(T element, int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 根据下标获取
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index >= size)
            {
                // return default(T);
                throw new IndexOutOfRangeException();
            }

            return (T)arrs[index];
        }

        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int IndexOf(T element)
        {
            for (var i = 0; i < size; i++)
            {
                if (arrs[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            foreach (var arr in arrs)
            {
                str.Append(arr);
            }

            return str.ToString();
        }
    }
}