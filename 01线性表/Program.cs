using System;

namespace _01线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 使用顺序表
            SeqList<string> seq = new SeqList<string>();
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

        }
    }
}
