using Singleton_Pattern.Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter The Limit");
        int nbr = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= nbr; i++)
        {
            PrinterSingleton.Instance.Print(i);
        }

        PrinterSingleton.Instance.Student(nbr + 1);
    }
}