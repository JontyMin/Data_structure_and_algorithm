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
     *
     * 一般用O表示法描述复杂度，表示的是数据规模n对应的复杂度 是一种粗略的分析模型
     *
     * 用尽量少的存储空间
     * 用尽量少的执行步骤（执行时间）
     *
     * 时间换空间
     * 空间换时间
     * */
    public static void main(String[] args) {
        int num = 50;
        System.out.println(fib1(num));
        System.out.println(fib2(num));
    }

    /*
     * O(2^n)
     * */
    public static int fib1(int n) {
        if (n <= 1) return n;
        return fib1(n - 1) + fib1(n - 2);
    }

    /*
     * // O(n)
     * */
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


    // O(n+k)
    public static void test(int n, int k) {
        for (int i = 0; i < n; i++) {
            System.out.println("test");
        }

        for (int i = 0; i < k; i++) {
            System.out.println("test");
        }

    }
}
