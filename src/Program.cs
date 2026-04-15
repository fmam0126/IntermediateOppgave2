using OppgaveGeneriskeTyper.Classes;

namespace OppgaveGeneriskeTyper;

class Program
{
    static void Main(string[] args)
    {
        var ageList = new Repository<int>();
        var nameList = new Repository<string>();

        var stack = new CustomStack<string>(5);

        nameList.Add("Gamer");
        ageList.Add(44);

        stack.Push("Gaming");
        stack.Push("Gamer");
        stack.Push("Game");

        Console.WriteLine(nameList.GetById(0));
        Console.WriteLine(ageList.GetById(0));

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());


    }
}
