using System;

namespace OppgaveGeneriskeTyper.interfaces;

public interface IPoppable<out T>
{
    T Pop();
}
