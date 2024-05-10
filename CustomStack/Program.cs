using CustomStack;

public class Program
{
    public static void Main(string[] args)
    {
        CustomStack<int> stack1 = new CustomStack<int>();

        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(3);
        stack1.Push(4);
        stack1.Push(5);
        stack1.Push(6);
        stack1.Push(7);
        stack1.Push(8);
        stack1.Push(9);
        stack1.Push(10);

        CustomStack<int> stack2 = new CustomStack<int>();

        stack2.Push(11);
        stack2.Push(12);
        stack2.Push(13);
        stack2.Push(14);
        stack2.Push(15);
        stack2.Push(16);
        stack2.Push(17);
        stack2.Push(18);
        stack2.Push(19);
        stack2.Push(20);

        CustomQueue<int> queue = new CustomQueue<int>();

        while(!stack1.IsEmpty)
        {
            var item = stack1.Pop();
            queue.Enqueue(item);
        }

        while (!stack2.IsEmpty)
        {
            var item = stack2.Pop();
            queue.Enqueue(item);
        }
    }
}

public class Stack
{
    public CustomStack<int> GeneratedStack1()
    {
        CustomStack<int> stack = new CustomStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        stack.Push(10);

        return stack;
    }

    public CustomStack<int> GeneratedStack2()
    {
        CustomStack<int> stack = new CustomStack<int>();

        stack.Push(110);
        stack.Push(109);
        stack.Push(108);
        stack.Push(107);
        stack.Push(106);
        stack.Push(105);
        stack.Push(104);
        stack.Push(103);
        stack.Push(102);
        stack.Push(101);

        return stack;
    }
}

