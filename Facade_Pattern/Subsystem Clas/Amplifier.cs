using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Subsystem_Clas
{
    public class Amplifier
    {
        public void on() => Console.WriteLine("Amplifier On");
        public void off() => Console.WriteLine("Amplifier Off");
        public void SetVolume(int level) => Console.WriteLine($"Setting Volume to {level}");
    }
}
