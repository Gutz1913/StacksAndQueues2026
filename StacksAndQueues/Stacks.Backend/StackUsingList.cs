namespace Stacks.Backend;

public class StackUsingList<T>
{
    private List<T> _elements = [];   //new List<T>() = []

    public void Push(T item) => _elements.Add(item);

    public T Pop()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Stack is empty.");
        }
        T item = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Stack is empty.");
        }
        return _elements[_elements.Count - 1];
    }
}