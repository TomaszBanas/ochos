using OchosClientConsole;

var connection = new Connection();

await connection.Connect("https://localhost:7118");

while (true)
{
    Console.WriteLine("Enter 'exit' to fisnih connection");
    var line = Console.ReadLine();
    if (line == "exit") break;
}

await connection.Dispose();