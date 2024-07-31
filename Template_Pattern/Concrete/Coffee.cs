using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Pattern.Template;

namespace Template_Pattern.Concrete
{
    public  class Coffee : PreparingTemplate
    {
        string Temp = "Cold";
        public override void BoilWater()
        {
            Console.WriteLine($"Adding {Temp} Water ");
        }
        protected override void Brew()
        {
            Console.WriteLine("Steeping the Coffee");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
