using Methods2.Ornek1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2.Ornek1.Concrete
{
    public class ProductA: Iproduct
    {
        public string ShipFrom()
        {
            return "AVrupaya";
        }
    }
}
