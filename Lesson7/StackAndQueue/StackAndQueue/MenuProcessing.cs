using System;
using System.Runtime.Remoting.Messaging;

namespace StackAndQueue
{
    public class MenuProcessing
    {
        private const int StackSize = 3;
        private StackUsingArray<int> myStack = new StackUsingArray<int>(StackSize);

        private const int QueueSize = 3;
        private QueueUsingArray<int> myQueue = new QueueUsingArray<int>(QueueSize);
        //private QueueUsingList myQueue = new QueueUsingList();

        private bool shouldExit = false;

        // Select Menu choice
        public void WorkWithMenuProcessing()
        {
            PrintMenu();
            do
            {
                PrintSelectAction();
                int choice = InputMenuChoice(1, 9);
                try
                {
                    ProcessMenuChoice(choice);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (shouldExit == false);
        }

        // Print Menu
        private void PrintMenu()
        {
            Console.Write(@"
Actions:
1. Call Action's Menu.
2. Push value into the Stack.
3. Pop value from the Stack.
4. Enqueue value into the Queue.
5. Dequeue value from the Queue.
6. Check if Stack is empty.
7. Check if Stack is full.
8. Peek value from the Stack.
9. Exit");
        }

        private void PrintSelectAction()
        {
            Console.Write("\nSelect action: ");
        }

        private void ProcessMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1: // Call Action's Menu.
                    PrintMenu();

                    break;

                case 2: // Push value into the Stack.
                {
                    Console.Write("\nPush value into the Stack: ");
                    int value = InputInteger();
                    try
                    {
                        myStack.EnqueuePush(value);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    myStack.PrintQueueStack();

                    break;
                }

                case 3: // Pop value from the Stack.
                    try
                    {
                        int dequeuePop = myStack.DequeuePop();
                        Console.WriteLine("Pop value from the Stack: " + dequeuePop);
                        myStack.PrintQueueStack();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 4: // Enqueue value into the Queue.
                {
                    Console.Write("\nEnqueue value into the Queue: ");
                    int value = InputInteger();
                    try
                    {
                        myQueue.EnqueuePush(value);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    myQueue.PrintQueueStack();


                    break;
                }

                case 5: // Dequeue value from the Queue.
                    try
                    {
                        int dequeuePop = myQueue.DequeuePop();
                        Console.WriteLine("Dequeue value from the Queue: " + dequeuePop);
                        myQueue.PrintQueueStack();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 6: // Check if Stack is empty.
                    if (myStack.IsEmpty())
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Stack is not empty");
                    }
                    
                    break;

                case 7: // Check if Stack is full.
                    if (myStack.IsFull())
                    {
                        Console.WriteLine("Stack is full.");
                    }
                    else
                    {
                        Console.WriteLine("Stack is not full");
                    }
                    
                    break;

                case 8: // Peek value from the Stack.
                    try
                    {
                        int peekValue = myStack.Peek();
                        Console.WriteLine("Peek value from the Stack: " + peekValue);
                        myStack.PrintQueueStack();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 9: // Exit
                    shouldExit = true;

                    break;
            }
        }

        // returns only Integer
        private int InputInteger()
        {
            int integerValue;
            do
            {
                string inputValue = Console.ReadLine();

                if (Int32.TryParse(inputValue, out integerValue))
                {
                    break;
                }
                else
                {
                    Console.Write("Please specify integer value: ");
                }
            } while (true);
            return integerValue;
        }

        // returns only integer from 1 to 9
        private int InputMenuChoice(int minChoice, int maxChoice)
        {
            int menuChoice;
            do
            {
                string inputValue = Console.ReadLine();

                if ((Int32.TryParse(inputValue, out menuChoice)) && (menuChoice >= minChoice) && (menuChoice <= maxChoice))
                {
                    break;
                }
                Console.Write("Please specify value from {0} to {1}: ", minChoice, maxChoice);
            } while (true);
            return menuChoice;
        }
    }
}
