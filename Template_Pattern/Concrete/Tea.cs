using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Pattern.Template;

namespace Template_Pattern.Concrete
{
    public  class Tea : PreparingTemplate
    {
        string Temp = "Hot";
        public override void BoilWater()
        {
            Console.WriteLine($"Boiling Water {Temp}");
        }
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
