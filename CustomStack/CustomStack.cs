using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack<T>
    {
        private T[] items;
        private int count;
        const int defaultCount = 10;

        public CustomStack()
        {
            items = new T[defaultCount];
        }

        public CustomStack(int length)
        {
            items = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");

            items[count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            T item = items[--count];
            items[count] = default(T);

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }

        private void Resize(int maxLength)
        {
            T[] tempItems = new T[maxLength];
            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i];
            }

            items = tempItems;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }

            return items[count - 1];
        }
    }

}
