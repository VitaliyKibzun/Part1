using System;

namespace StackAndQueue
{
    class QueueUsingArray<T> : Buffer<T>, IMyQueue<T>
    {
        public QueueUsingArray(int queueSize) : base("Queue", queueSize)
        {
        }

        public override T DequeuePop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T dequeueValue = MyQueueStack[0];
            for (int i = 1; i < Pointer; i++)
            {
                MyQueueStack[i - 1] = MyQueueStack[i];
            }
            Pointer--;
            return dequeueValue;
        }
    }
}
