using Adapter_Pattern.Adapter;
using Adapter_Pattern.NewPayment;
using Adapter_Pattern.OldPayment;

class Program
{
    static void Main(string[] args)
    {
        IOldPayment oldPayment = new OldPayment();

        INewPayment newPayment = new AdapterPayment(oldPayment);

        newPayment.MakePayment(100);
    }
}