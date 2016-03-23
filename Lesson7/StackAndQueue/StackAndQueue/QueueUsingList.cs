using System;

namespace StackAndQueue
{
    public class QueueUsingList
    {
        private Item firstItem = null;
        private Item lastItem = null;
        private Item currentItem = null;
        private int maxSize = 3;
        private int currentLength = 0;

        // Constructor
        public QueueUsingList()
        {
            Console.WriteLine("Queue (size={0}): <empty> ", maxSize);
        }

        // adds value to the Queue
        public void Enqueue(int value)
        {
            if (currentLength == 0)
            {
                firstItem = lastItem = new Item(value, null);
            }
            else if (currentLength < maxSize)
            {
                lastItem.PointerToNextItem = new Item(value, null);
                lastItem = lastItem.PointerToNextItem;
            }
            else
            {
                Console.WriteLine("Queue is full. Value cound't be added.");
                ShowQueue();
                return;
            }
            currentLength ++;
            ShowQueue();
        }

        // Takes value from the Queue
        public int Dequeue()
        {
            int dequeueData = 0;
            if (currentLength != 0)
            {
                currentItem = firstItem;
                dequeueData = currentItem.Data;
                firstItem = firstItem.PointerToNextItem;
                currentItem = null;
                currentLength --;
                
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
            return dequeueData;
        }

        // checks if Queue is empty
        public bool IsEmpty()
        {
            if (currentLength == 0)
            {
                return true;
            }
            return false;
        }

        // checks if Queue is full
        public bool IsFull()
        {
            if (currentLength == maxSize)
            {
                return true;
            }
            return false;
        }

        // Shows Queue
        public void ShowQueue()
        {
            Console.Write("Queue: ");
            currentItem = firstItem;
            if (currentItem == null)
            {
                Console.Write("<empty>");
            }
            while (currentItem != null)
            {
                Console.Write(currentItem.Data + " ");
                currentItem = currentItem.PointerToNextItem;
            }
            Console.WriteLine();
        }
    }

    // Creates new Item with Data and reference.
    class Item
    {
        public int Data;
        public Item PointerToNextItem;
        
        public Item(int data, Item pointerToNextItem)
        {
            Data = data;
            PointerToNextItem = pointerToNextItem;
        }
    }
}
