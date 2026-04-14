using System;
using System.ComponentModel;
using OppgaveGeneriskeTyper.interfaces;

namespace OppgaveGeneriskeTyper.Classes;

public class Repository<T> : IRepository<T>
{
    private List<T> _storage = new List<T>();
    public void Add(T item)
    {
        _storage.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return _storage;
    }

    public T GetById(int index)
    {
        if (index < 0 || index >= _storage.Count)
        {
            throw new IndexOutOfRangeException("Could not find the requested element. Index is out of range");
        }
        return _storage[index];
    }

    public bool Remove(T item)
    {
        return _storage.Remove(item);
    }

    public void Update(T value, int index)
    {
        if (index < 0 || index >= _storage.Count)
        {
            throw new IndexOutOfRangeException("Could not update Value. Index is out of range");
        }
        _storage[index] = value;
    }
}