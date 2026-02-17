namespace Stacks.Backend;

public class StackUsingArray<T>
{
    private T[] _elements = null!;
    private int _top;

    public StackUsingArray(int capacity)
    {
        _elements = new T[capacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == _elements.Length - 1)
        {
            throw new Exception("Stack is full.");
        }
        _elements[++_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new Exception("Stack is empty");
        }
        return _elements[_top--];
    }

    public T Peek()
    {
        if (_top == -1)
        {
            throw new Exception("Stack is empty");
        }
        return _elements[_top];
    }
}