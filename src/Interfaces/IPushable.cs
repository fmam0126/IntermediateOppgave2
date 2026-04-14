using System;

namespace OppgaveGeneriskeTyper.interfaces;

public interface IPushable<in T>
{
    void Push(T obj);
}
