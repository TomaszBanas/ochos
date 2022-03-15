
using OchosClientConsole;

var manager = new ActionManager();

var actions = manager.GetActions();
for (int i = 0; i < actions.Count; i++)
{
    Console.WriteLine($"{i + 1}) {actions[i].Name}");
}


while (true)
{
    var line = Console.ReadLine();
    if (line == "exit")
        return;

    int? no = int.TryParse(line, out var i) ? i : null;
    if (no.HasValue)
        await manager.ExecuteAction(actions[i - 1]);
}