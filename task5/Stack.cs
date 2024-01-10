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
        T value = values[values.Count - 1];
        values.Remove(value);
        return value;
    }
    public T Peek()
    {
        return values[values.Count - 1];
    }
}

