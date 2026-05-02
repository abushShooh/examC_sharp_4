public class Stack<T>
{
    private List<T> _list = new List<T>();

    public void Push(T element)
    {
        _list.Add(element);
    }

    public bool Empty()
    {
        return _list.Count == 0;
    }

    public T Pop()
    {
        int last = _list.Count - 1;
        T element = _list[last];
        _list.RemoveAt(last);
        return element;
    }

    public T Peek()
    {
        int last = _list.Count - 1;
        return _list[last];
    }
}
