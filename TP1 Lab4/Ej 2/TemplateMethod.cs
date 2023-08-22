using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lab4.Ej_2
{
    abstract class BeverageTemplate
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            Console.WriteLine("Beverage is ready!");
        }

        protected void BoilWater() => Console.WriteLine("Boiling water");
        protected abstract void Brew();
        protected abstract void PourInCup();
    }

    class Tea : BeverageTemplate
    {
        protected override void Brew() => Console.WriteLine("Steeping the tea");
        protected override void PourInCup() => Console.WriteLine("Pouring tea into cup");
    }

    class Coffee : BeverageTemplate
    {
        protected override void Brew() => Console.WriteLine("Dripping coffee through filter");
        protected override void PourInCup() => Console.WriteLine("Pouring coffee into cup");
    }

}
