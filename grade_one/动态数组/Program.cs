using System;

namespace 动态数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new ArrayList<string>();
            
            arr.Add("aa");

            Console.WriteLine(arr.IndexOf("aa"));
        }
    }
}
