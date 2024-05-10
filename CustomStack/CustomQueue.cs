using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{

    public class CustomQueue<T>
    {
        private T[] queues;
        private int count;
        const int defaultCount = 4;

        public CustomQueue()
        {
            queues = new T[defaultCount];
        }

        public CustomQueue(int length)
        {
            queues = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public void Clear()
        {
            Array.Clear(queues, 0, queues.Length);
        }

        public void Enqueue(T item)
        {
            if (count == queues.Length)
                Resize(queues.Length * 2);

            queues[count++] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Очередь пуста");

            T queue = queues[0];
            queues[count] = default(T);


            if (count > 0 && count < queues.Length - 10)
                Resize(queues.Length - 10);

            T[] tempQueue = new T[queues.Length - 1];

            for (var i = 0; i < queues.Length - 1; i++)
            {
                int ii = i + 1;
                tempQueue[i] = queues[ii];
            }

            queues = tempQueue;
            return queue;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            T queue = queues[0];

            return queue;
        }

        private void Resize(int maxLength)
        {
            T[] tempArray = new T[maxLength];
            for (int i = 0; i < queues.Length; i++)
            {
                tempArray[i] = queues[i];
            }

            queues = tempArray;
        }

        public bool Contains(T item)
        {
            if (IsEmpty)
                throw new InvalidOperationException("Очередь пуста");

            bool findItem = queues.Contains(item);

            return findItem;
        }
    }
}
