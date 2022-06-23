using Methods2.Ornek1.Abstract;
using Methods2.Ornek1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2.Ornek1.Creater
{
    internal class ProductCreater
    {
        public Iproduct FactoryMethod(int ay)
        {
            if (ay==1 || ay==3 ||ay==6)
            {
                return new ProductA();
            }
            else if (ay == 2 || ay == 4 || ay == 5)
            {
                return new ProductB();
            }
            else if (ay == 7 || ay == 8)
            {
                return new ProductC();
            }
            else
            {
                return new DefaultProduct();
            }
        }

    }
}
