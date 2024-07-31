
namespace Singleton_Pattern.Singleton
{
    public class PrinterSingleton
    {
        private static PrinterSingleton instance = null;
        private static PrinterSingleton locker = new PrinterSingleton();
        private PrinterSingleton() { }

        public static PrinterSingleton Instance
        {
            get 
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PrinterSingleton();
                    }
                    return instance;
                }
            }
        }
        public void Print(int queue)
        {
            Console.WriteLine("Prinitng Document: Queue " + queue);
        }

        public void Student(int queues)
        {
            Console.WriteLine("Student Prinitng Document : Queue " + queues);
        }
    }
}
