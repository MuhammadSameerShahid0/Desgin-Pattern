namespace Facade_Pattern.Subsystem_Clas
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Dvd Palyer On");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"Playing Movie :{movie}");
        }
        public void Off()
        {
            Console.WriteLine("Dvd Palyer Off");
        }
    }
}
