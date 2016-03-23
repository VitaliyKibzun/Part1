using System;

namespace StackAndQueue
{
    abstract class Buffer<T> : IBuffer<T>
    {
        #region Protected fields

        protected T[] MyQueueStack;
        protected int Pointer = 0;
        protected int MaxSize = 0;

        #endregion

        #region Private fields

        private string _queueOrStack;

        #endregion

        #region Constructors

        protected Buffer(string queueOrStack, int size)
        {
            _queueOrStack = queueOrStack;
            MaxSize = size;
            MyQueueStack = new T[MaxSize];
            Console.WriteLine("{1} (size={0}): <empty> ", MaxSize, _queueOrStack);
        }

        #endregion

        #region IBuffer<T> implementation

        public void EnqueuePush(T value)
        {
            if (IsFull())
            {
                throw new InvalidOperationException(String.Format("{0} is full. Value couldn't be added.", _queueOrStack));
            }

            MyQueueStack[Pointer] = value;
            if (Pointer < MaxSize)
            {
                Pointer++;
            }
        }

        public bool IsEmpty()
        {
            if (Pointer <= 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if (Pointer == MaxSize)
            {
                return true;
            }
            return false;
            
        }

        #endregion

        #region Abstract methods

        public abstract T DequeuePop();

        #endregion

        #region IPrintable

        public void PrintQueueStack()
        {
            Console.Write("{0}: ", _queueOrStack);
            if (Pointer == 0)
            {
                Console.Write("<empty>");
            }
            else
            {

                for (int i = 0; i < Pointer; i++)
                {
                    Console.Write(MyQueueStack[i] + " ");
                }
            }
            Console.WriteLine();
        }

        #endregion
    }
}
