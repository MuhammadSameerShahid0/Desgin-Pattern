using Facade_Pattern.Subsystem_Clas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Facade
{
    public class HomeTheater
    {
        private Amplifier _amplifier;
        private DvdPlayer _dvdPlayer;
        private Projector _projector;

        public HomeTheater(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _amplifier.on();
            _amplifier.SetVolume(5);
            _projector.On();
            _projector.SetInput("DVD");
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater...");
            _amplifier.off();
            _projector.Off();
            _dvdPlayer.Off();
        }
    }
}
