namespace Queues.Backend;

public class QueueUsingList<T>
{
    private List<T> _elements;

    public QueueUsingList()
    {
        _elements = [];     //New List<T>();
    }

    public void Enqueue(T item)
    {
        _elements.Add(item);        //Add item to the end of the list
    }

    public T Dequeue()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Queue is empty");
        }
        var item = _elements[0];    //Get the first item
        _elements.RemoveAt(0);      //Remove the first item
        return item;                //Return the dequeued item
    }

    public T Peek()
    {
        if (_elements.Count == 0)
        {
            throw new Exception("Queue is empty");
        }
        return _elements[0];
    }
}