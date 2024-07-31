using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Subsystem_Clas
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector On");
        }
        public void SetInput(string input)
        {
            Console.WriteLine($"Setting Input :{input}");
        }
        public void Off()
        {
            Console.WriteLine("Projector Off");
        }
    }
}
