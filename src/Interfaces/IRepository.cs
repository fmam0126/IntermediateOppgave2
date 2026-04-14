using System;

namespace OppgaveGeneriskeTyper.interfaces;
/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
{
    void Add(T item);            // Add to the repository
    IEnumerable<T> GetAll();     // Get all items from the repository
    T GetById(int index);        // Get a specific item based on index from the repository
    void Update(T value, int index); // Update a specified index with with a value
    bool Remove(T item);         // Remove from the repository
}