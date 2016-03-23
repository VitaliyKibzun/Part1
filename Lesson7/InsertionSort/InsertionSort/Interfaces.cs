using System;

namespace SortApp
{
    public interface IPrintable
    {
        void ShowArray();
    }

    public interface ISorter<T> : IPrintable where T : IComparable<T>
    {
        void Sorter(T[] MyArray);
    }
}