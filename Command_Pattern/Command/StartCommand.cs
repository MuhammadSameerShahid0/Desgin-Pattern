using Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command
{
    public class StartCommand : ITV
    {
        string name = "Start";
        public string Name()
        {
            return name;
        }
        public void Exectue()
        {
            Console.WriteLine($"{name} Command Execute Succesfully");
        }
    }
}
