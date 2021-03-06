﻿using System;
using System.Collections.Generic;

namespace _02栈
{
    class Program
    {

        /*
         * 栈(Stack)是操作限定在表的尾端进行的线性表
         * 表尾：栈顶=>Top  栈底=>Buttom
         * 无数据 空栈=>Empty Stack
         * 栈的操作是按照 后进先出(Last in First out) 简称LIFO表
         * 先进后出(First in Last out) FILO表
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // 1、使用BCL中的Stack<T>

            // Stack<char>stack=new Stack<char>();

            // 2、使用自定义
            // IStackDs<char>stack=new SeqStack<char>(20);


            // 3、使用链栈
            IStackDs<char> stack = new LinkStack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');

            Console.WriteLine($"Push:{stack.Count}");

            var temp = stack.Pop();// 获取栈顶的数据并删除
            Console.WriteLine($"Pop:{stack.Count}");

            var pek = stack.Peek();// 获取栈顶数据，不删除
            Console.WriteLine($"Peek:{stack.Count}");

            stack.Clear();
            Console.WriteLine($"Clear:{stack.Count}");

            // Stack Empty异常 空栈不要Pop/Peek
            Console.WriteLine($"空栈:{stack.Peek()}");

            
        }
    }
}
