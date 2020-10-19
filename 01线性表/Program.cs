using System;

namespace _01线性表
{
    class Program
    {
        /*
         * 线性表是线性结构的抽象
         * 特点：结构中的数据元素之间存在一对一的线性关系=>位置
         * C# 1.1提供了非泛型接口IList:ArrayList、ListDictionary...
         * C# 2.0提供了泛型IList<T>接口
         * 线性表：1、顺序表:顺序存储(Sequence Storage) 内存中一块地址连续的空间依次存放
         *       2、单链表:链式存储(Linked Storage)用一组任意的存储单元来存储线性表中的数据元素
         *       3、双向链表:(Doubly Linked List)
         *       4、循环链表:(Circular Linked List)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 使用顺序表
            IListDs<string> seq = new SeqList<string>();
            seq.Add("123");
            seq.Add("456");
            seq.Add("789");
            seq.Insert("777", 1);
            for (int i = 0; i < seq.GetLength(); i++)
            {
                Console.WriteLine(seq[i]);
            }

            //删除元素
            seq.Delete(0);
            for (int i = 0; i < seq.GetLength(); i++)
            {
                Console.WriteLine(seq[i]);
            }

            seq.Clear();
            for (int i = 0; i < seq.GetLength(); i++)
            {
                Console.WriteLine(seq[i]);
            }

            Console.WriteLine(seq.IsEmpty());


            Console.WriteLine("---------LinkList--------");
            IListDs<string> linkList=new LinkList<string>();
            linkList.Add("123");
            linkList.Add("456");
            linkList.Add("789");
            for (int i = 0; i < linkList.GetLength(); i++)
            {
                Console.WriteLine(linkList[i]);
            }

            Console.WriteLine($"GetItem:{linkList.GetItem(1)}");

            linkList.Insert("777", 1);
            for (int i = 0; i < linkList.GetLength(); i++)
            {
                Console.WriteLine(linkList[i]);
            }

            Console.WriteLine("----clear---");
            linkList.Clear();
            for (int i = 0; i < linkList.GetLength(); i++)
            {
                Console.WriteLine(linkList[i]);
            }
            Console.WriteLine("----end clear---");

        }
    }
}
