using System.Collections.Concurrent;

namespace DP.P013.Employee_MaxObjts_ObjectPoolPattern.ConsoleApp;

public class ObjectPool<T> where T : new()
{
    private readonly int _maxSize;
    private readonly Func<T> _constructor;
    private readonly ConcurrentBag<T> _pool;

    public ObjectPool(int maxSize, Func<T> constructor)
    {
        _maxSize = maxSize;
        _constructor = constructor;
        _pool = new ConcurrentBag<T>();
        InitializePool();
    }

    private void InitializePool()
    {
        for (int i=0; i< _maxSize; i++)
        {
            var item = _constructor();
            _pool.Add(item);
        }
    }

    public int PoolCount => _pool.Count;

    public int PoolMaxSize => _maxSize;

    public T Get()
    {
        if (PoolCount > 0)
        {
            T item;
            if (_pool.TryTake(out item))
                return item;
        }

        throw new Exception("You are out of items. Return some to the pool and try again");
    }

    public void Release(T item)
    {
        if(PoolCount <= _maxSize)
        {
            _pool.Add(item);
            return;
        }

        throw new Exception("Trying to release an extra item");
    }
}
