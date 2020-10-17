using System;

namespace _01线性表
{
    class Program
    {
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
