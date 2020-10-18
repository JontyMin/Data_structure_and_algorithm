using System;

namespace _04字符串
{
    public class StringDS
    {
        private char[] data;// 存放字符

        public StringDS(char[]array)
        {
            data=new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }

        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = str[i];
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public char this[int index]
        {
            get
            {
                return data[index];
            }
        }

        /// <summary>
        /// 获取字符串长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return data.Length;
        }

        /// <summary>
        /// 比较字符串是否相等 ASCII
        /// 相等返回0
        /// 当前字符串小于s 返回-1
        /// 当前字符串大于s 返回1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Compare(StringDS s)
        {
            // 获取较小字符串长度
            var len = GetLength() < s.GetLength() ? GetLength() : s.GetLength();

            int index = -1;// 不相等索引位置
            for (int i = 0; i < len; i++)
            {
                if (this[i]!=s[i])
                {
                    index = i;
                    break;
                }
            }

            if (index!=-1)
            {
                if (this[index]>s[index])
                {
                    return 1;

                }
                else
                {
                    return -1;
                }
            }
            else
            {
                // 长度相等
                if (this.GetLength()==s.GetLength())
                {
                    return 0;
                }
                else
                {
                    // 长度不相等
                    if (this.GetLength()>s.GetLength())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public StringDS SubString(int index, int length)
        {
            char[] newData = new char[length];
            for (int i = index; i < index+length; i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static StringDS Concat(StringDS s1, StringDS s2)
        {
            char[]newData = new char[s1.GetLength()+s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }

            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }

            return new StringDS(newData); 
        }

        public int IndexOf(StringDS s)
        {
            for (int i = 0; i < this.GetLength()-s.GetLength(); i++)
            {
                bool isEqual = true;
                for (int j = i; j < i+s.GetLength(); j++)
                {
                    if (this[j]!=s[j-i])
                    {
                        isEqual = false;
                    }
                }

                if (isEqual)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }

            return -1;
        }

        public string ToString()
        {
            return new string(data);
        }
    }
}