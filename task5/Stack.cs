namespace task5;

public class Stack<T>
{
    List<T> values = new List<T>();
    public void Push(T item)
    {
        values.Add(item);
    }
    public T Pop()
    {
        T value = values.Last();
        values.Remove(value);
        return value;
    }
    public T Peek()
    {
        return values.Last();
    }
}

