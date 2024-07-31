using Facade_Pattern.Facade;
using Facade_Pattern.Subsystem_Clas;

class Program
{
    static void Main(string[] args)
    {
        Amplifier amplifier = new Amplifier();
        DvdPlayer player = new DvdPlayer();
        Projector projector = new Projector();

        HomeTheater homeTheater = new HomeTheater(amplifier , player , projector);

        homeTheater.WatchMovie("SpiderMan");
        homeTheater.EndMovie();
    }
}