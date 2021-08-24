using System;

namespace _05排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 42, 20, 17, 27, 8, 17, 48 };
            InsertSort(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------");
            SelectSort(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            QuickSort(arr,0,arr.Length-1);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// 对数组中索引从left到right之间的数排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // 基准数 把比它小或者等于它的放在左边
                // 比它大的放在右边
                int x = array[left];
                int i = left;

                // 循环的标志位
                int j = right;

                // 中间数
                while (true && i < j)
                {

                    // 从后往前比较(从右往左)找一个比x小或等于的数字
                    // 放在i的位置
                    while (true && i < j)
                    {
                        // 找到一个比基准数 小于或等于的数 放在x左边
                        if (array[j] <= x)
                        {
                            array[i] = array[j];
                            break;
                        }
                        else
                        {
                            // 向左移动到下一个数字 作比较
                            j--;
                        }
                    }

                    // 从前往后(从左往右)
                    while (true && i < j)
                    {
                        if (array[i] > x)
                        {
                            array[j] = array[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                // i==j 跳出循环
                array[i] = x;

                QuickSort(array,left,i-1);
                QuickSort(array,i+1,right);
            }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="array"></param>
        static void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];

                int minIndex = i;// 最小值索引

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        /// <summary>
        ///  插入排序
        /// </summary>
        /// <param name="array"></param>
        static void InsertSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var iValue = array[i];
                var isInsert = false;
                // 拿到i位置的元素，跟前面所有元素做比较
                // 如果发现比i大的，就让它向后移动
                for (var j = i - 1; j >= 0; j--)
                    if (array[j] > iValue)
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        // 发现一个比i小的值就不移动了
                        array[j + 1] = iValue;
                        isInsert = true;
                        break;
                    }
                if (!isInsert) array[0] = iValue;
            }
        }
    }
}
