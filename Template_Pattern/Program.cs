using Template_Pattern.Concrete;
using Template_Pattern.Template;

class Program
{
    static void Main(string[] args)
    {
        PreparingTemplate Tea = new Tea();
        PreparingTemplate Coffee =  new Coffee();

        Console.WriteLine("Making Tea : ");
        Tea.PrepaingRecipe();
        Console.WriteLine("\n ");
        Console.WriteLine("Making Coffee : ");
        Coffee.PrepaingRecipe();
    }
}