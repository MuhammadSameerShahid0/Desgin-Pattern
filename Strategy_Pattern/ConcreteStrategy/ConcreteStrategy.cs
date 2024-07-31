using Strategy_Pattern.Interface;

namespace Strategy_Pattern.ConcreteStrategy
{
    public class CreditCard : IPaymentStrategy
    {
        private string _CardHolder;
        private string _CardNumber;
        private string _CVC;

        public CreditCard(string cardHolder, string cardNumber, string cVC)
        {
            _CardHolder = cardHolder;
            _CardNumber = cardNumber;
            _CVC = cVC;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} , Using Credit Card.");
        }
    }

    public class PayPal : IPaymentStrategy
    {
        private string _Email;

        public PayPal(string email)
        {
            _Email = email;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} , Using PayPal.");
        }
    }

    public class BankTransfer : IPaymentStrategy
    {
        private string _AccountNumber;
        private string _BankCode;

        public BankTransfer(string accountNumber, string bankCode)
        {
            _AccountNumber = accountNumber;
            _BankCode = bankCode;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} , Using Bank Transfer.");
        }
    }
}
