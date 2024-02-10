try
{
    Stack<int> stack = new Stack<int>();
    System.Console.WriteLine(stack.Pop());
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    System.Console.WriteLine(stack.Pop());
    System.Console.WriteLine(stack.Peek());
}
catch
{
    Console.WriteLine("This list is empty!");
}
