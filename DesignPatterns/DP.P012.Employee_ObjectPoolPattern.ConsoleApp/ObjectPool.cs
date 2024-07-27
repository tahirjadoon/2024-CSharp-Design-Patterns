using System.Collections.Concurrent;

namespace DP.P012.Employee_ObjectPoolPattern.ConsoleApp;

public class ObjectPool<T> where T : new()
{
    private readonly ConcurrentBag<T> _items = new ConcurrentBag<T>();

    private int _counter = 0;
    private int _poolSize = 10;

    public int PoolCount => _counter;

    public void Release(T item)
    {
        if(_counter < _poolSize)
        {
            _items.Add(item);
            _counter++;
        }
    }

    public T Get()
    {
        //take from pool or add
        T item;
        if(_items.TryTake(out item))
        {
            _counter--;
            return item;
        }

        item = new T();
        //_items.Add(item);
        //_counter++;
        return item;
    }

}
