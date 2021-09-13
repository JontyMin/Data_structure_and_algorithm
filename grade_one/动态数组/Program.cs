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
            arr.Add("bb");
            arr.Add("cc");
            arr.Add("ee");
            arr.Add("ff");
            Console.WriteLine(arr.ToString());

            arr.Remove(2);

            arr.Add("43",arr.Size()-1);
            Console.WriteLine(arr.ToString());


        }
    }
}
