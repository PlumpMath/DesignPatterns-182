using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtrastFactory
{
    class Client
    {
        private AbstractProductA absProductA;
        private AbstractProductB absProductB;
        public Client(AbstractFactory factory)
        {
            absProductA = factory.CreateProductA();
            absProductB = factory.CreateProductB();
        }
        public void Run()
        {
            absProductB.Interact(absProductA);
        }
    }
}
