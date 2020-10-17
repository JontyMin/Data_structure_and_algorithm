namespace _02栈
{
    public class SeqStack<T>:IStackDs<T>
    {
        private T[] data;
        private int top;//指向栈顶top

        public SeqStack(int size)
        {
            data=new T[size];
            top = -1;
        }

        public SeqStack() : this(10)
        {
            
        }

        public int Count
        {
            get => top + 1;
        }
        public int GetLength()
        {
            return Count;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void Clear()
        {
            top = -1;
        }

        public void Push(T item)
        {
            data[top + 1] = item;
            top++;
        }

        public T Pop()
        {
            var temp = data[top];
            top--;
            return temp;
        }

        public T Peek()
        {
            return data[top];
        }
    }
}