using System;

class Stack<T>
{
    private T[] data;
    private int top;
    private const int DefaultCapacity = 10;

    public Stack()
    {
        data = new T[DefaultCapacity];
        top = -1; // Initialize top to -1, indicating an empty stack
    }

    public void Push(T item)
    {
        if (top == data.Length - 1)
        {
            //the stack full needto recognize the size
            Array.Resize(ref data, data.Length * 2);
        }

        top++;
        data[top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = data[top];
        top--;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return data[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public int Count()
    {
        return top + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        // Push some elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack Count: " + stack.Count());

        // Pop elements from the stack
        Console.WriteLine("Popped item: " + stack.Pop());
        Console.WriteLine("Popped item: " + stack.Pop());

        Console.WriteLine("Stack Count: " + stack.Count());

        // Peek at the top element without removing it
        Console.WriteLine("Top item: " + stack.Peek());

        Console.WriteLine("Is Stack Empty: " + stack.IsEmpty());

        // Pop the remaining element
        Console.WriteLine("Popped item: " + stack.Pop());

        Console.WriteLine("Is Stack Empty: " + stack.IsEmpty());
    }
}
