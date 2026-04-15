using System;
using OppgaveGeneriskeTyper.interfaces;

namespace OppgaveGeneriskeTyper.Classes;

public class CustomStack<T>(int stackSize) : IPushable<T>, IPoppable<T>
{
    private int _position;
    private T[] _stack = new T[stackSize];
    public void Push(T obj)
    {
        _stack[_position++] = obj;
    }
    public T Pop()
    {
        return _stack[--_position];
    }
}