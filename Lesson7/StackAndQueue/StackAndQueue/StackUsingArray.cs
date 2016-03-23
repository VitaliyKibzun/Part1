using System;

namespace StackAndQueue
{
    class StackUsingArray<T> : Buffer<T>, IMyStack<T>
    {
        public StackUsingArray(int maxSize): base("Stack", maxSize)
        {
        }

        public override T DequeuePop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T lastValue = MyQueueStack[Pointer - 1];
            Pointer --;
            return lastValue;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return MyQueueStack[Pointer-1];
        }
    }
}
