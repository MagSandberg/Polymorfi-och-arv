using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    // En abstrakt klass går INTE att instansiera (alltså skapa objekt utav)
    public abstract class Vehicle
    {
        public int TopSpeed { get; set; }
        public int NumberOfWheels{ get; set; }
        public string Color { get; set; }


        //Ger gemensamt beteende för alla barnklasser(subtyper) som GÅR att ändra
        public virtual void MakeSound()
        {
            Console.WriteLine("Vehicle goes *VROOM*");
        }

        //Ger gemensamt beteende för alla barnklasser(subtyper) som INTE kan ändras
        public void PrintTopSpeed()
        {
            Console.WriteLine(TopSpeed);
        }

        public void PrintNumberOfWheels()
        {
            Console.WriteLine(NumberOfWheels);
        }


        //Tvingar alla barnklasser(subtyper) att implementera beteendet
        public abstract void PrintInfo();
    }
}
