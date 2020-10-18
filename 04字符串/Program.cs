using System;
namespace _04字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringDS s = new StringDS("I am a teacher");
            StringDS i = new StringDS("excellent");
            StringDS r = new StringDS("Student");
            Console.WriteLine(s.GetLength());
            Console.WriteLine(i.GetLength());
            Console.WriteLine(r.GetLength());

            StringDS s2 = s.SubString(8, 4);
            Console.WriteLine(s2.ToString());

            StringDS i2 = i.SubString(2, 1);
            Console.WriteLine(i2.ToString());

            Console.WriteLine(s.IndexOf(new StringDS("tea")));
        }
    }
}
