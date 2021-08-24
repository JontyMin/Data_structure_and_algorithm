package com.company.复杂度;

public class demo01 {
    /*
     * 斐波那契数列
     * 0，1，1，2，3，5，8，13
     *
     * 事后统计法
     * 比较不同算法对同一组输入的执行时间
     *
     * 正确性、可读性、健壮性
     * 时间复杂度：估算程序指令的执行次数（时间）
     * 空间复杂度：估算所需占用的存储空间
     * */
    public static void main(String[] args) {
        int num = 9;
        System.out.println(fib1(num));
        System.out.println(fib2(num));
    }

    public static int fib1(int n) {
        if (n <= 1) return n;
        return fib1(n - 1) + fib1(n - 2);
    }

    public static int fib2(int n) {
        if (n <= 1) return n;

        int first = 0;
        int second = 1;
        for (int i = 0; i < n - 1; i++) {
            int sum = first + second;
            first = second;
            second = sum;
        }
        return second;
    }
}
