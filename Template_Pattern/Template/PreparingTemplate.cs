using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern.Template
{
    public abstract class PreparingTemplate
    {
        // Template
        public void PrepaingRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }        
        private void PourInCup()
        {
            Console.WriteLine("Pour In Cup");
        }
        public abstract void BoilWater();
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}
