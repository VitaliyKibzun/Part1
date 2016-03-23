namespace StackAndQueue
{
    public interface IPrintable
    {
        void PrintQueueStack();
    }

    public interface IBuffer<T> : IPrintable
    {
        void EnqueuePush(T value);
        bool IsEmpty();
        bool IsFull();
    }

    public interface IMyStack<T>
    {
        T DequeuePop();
        T Peek();
    }

    public interface IMyQueue<T>
    {
        T DequeuePop();
    }
}