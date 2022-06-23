using Methods2.Ornek1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2.Ornek1.Concrete
{
    internal class DefaultProduct:Iproduct
    {
        public string ShipFrom()
        {
            return "hiçbir yere gitmez. yurtiçine dağıtım";
        }
    }
}
