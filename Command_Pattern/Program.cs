using Command_Pattern.Interfaces;
using Command_Pattern.Invoker;
using System.Windows.Input;
class Program
{
    static void Main(string[] args)
    {
        Invoker invoker = new Invoker();

        Console.WriteLine("Enter the command :");
        string commandName = Console.ReadLine();
        ITV command = invoker.GetCommand(commandName);

        if (command != null)
        {
            command.Exectue();
            Console.WriteLine("Command executed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid command.");
        }
    }
}