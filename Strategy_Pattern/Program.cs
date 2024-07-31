
using Strategy_Pattern;
using Strategy_Pattern.ConcreteStrategy;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        Console.WriteLine("Choose payment method: 1. Credit Card, 2. PayPal, 3. Bank Transfer");
        int Choice = int.Parse(Console.ReadLine());

        switch (Choice)
        {
            case 1:
                cart.SetPayment(new CreditCard("Ali", "100 - 000 - 0000 - 000", "009"));
                break;
            case 2:
                cart.SetPayment(new PayPal("Ali@example.com"));
                break;
            case 3:
                cart.SetPayment(new BankTransfer("00000-00000000-0000", "1305"));
                break;
            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        cart.Checkout(100.0m);
    }
}