using Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command
{
    public class StopCommand : ITV 
    {
        public void Exectue()
        {
            Console.WriteLine("Stop Command Execute");
        }

        public string Name()
        {
            return "Stop";

        }
    }
}
