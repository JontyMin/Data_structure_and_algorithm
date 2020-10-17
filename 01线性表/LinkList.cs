using System;

namespace _01线性表
{
    /// <summary>
    /// 单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkList<T> : IListDs<T>
    {
        // 链表使用节点存储

        // 存储头节点
        private Node<T> head;

        public LinkList()
        {
            head = null;
        }

        /// <summary>
        /// 获取链表长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            if (head == null) return 0;
            var temp = head;
            var count = 1;
            while (true)
                if (temp.Next!=null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    break;
                }

            return count;
        }

        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()
        {
            head = null;// 头节点没有引用 GC会自动回收
        }

        /// <summary>
        /// 链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            // 创建一个新的节点
            Node<T> newNode = new Node<T>(item);

            // 如果头节点为空，则当前节点为头节点
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                // 头部不为空 把新节点放到链表尾节点

                // 获取尾节点
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }

                temp.Next = newNode;// 把新节点放到尾部

            }
        }

        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index)
        {
            // 插入节点 上一节点的下一节点为新节点，新节点的下一节点指向原下一节点
            // 插入头节点
            Node<T> newNode = new Node<T>(item);
            if (index == 0)
            {
                // 新节点下一节点指向原头节点
                newNode.Next = head;
                // 头节点为当前新节点
                head = newNode;
            }
            else
            {
                Node<T> temp = head;// 当前头节点
                for (int i = 1; i < index-1; i++)
                {
                    // 让temp向后移动index位置
                    // 就是要插入的位置
                    temp = temp.Next;
                }
                // 上一节点就是当前节点
                Node<T> preNode = temp;
                // 下一节点就是当前节点的下一节点
                Node<T> currNode = temp.Next;
                // 设置上一节点指向新节点
                preNode.Next = newNode;
                // 新节点指向下一节点
                newNode.Next = currNode;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index)
        {
           // 1、删除头节点
           // 2、删除中间节点
           // 3、删除最后一个节点

           T data = default(T);

           if (index==0)
           {
               data = head.Data;
               head = head.Next;// 下一个节点为头节点
           }
           else
           {
               Node<T> temp = head;
               for (int i = 1; i < index-1; i++)
               {
                   temp = head.Next;
               }

               Node<T> preNode = temp;
               Node<T> currNode = temp.Next;
               data = currNode.Data;
               preNode.Next = temp.Next.Next;
           }

           return data;
        }

        public T this[int index]
        {
            get
            {
                var temp = head;
                for (var i = 1; i <= index; i++) temp = temp.Next;

                return temp.Data;
            }
        }
        public T GetItem(int index)
        {
            return this[index];
        }

        public int Locate(T value)
        {
            Node<T> temp = head;
            if (head==null)
            {
                return -1;
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        if (temp.Next!=null)
                        {
                            temp = temp.Next;
                        }
                        else
                        {
                            break;
                        }
                    }

                    index++;
                }

                return -1;
            }
        }
    }
}