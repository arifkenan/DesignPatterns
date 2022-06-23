using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Lab2.Concrete
{
    public class CEO : MasrafYonetimiBase
    {
        public override void MasrafYonetimi(Masraf masraf)
        {
            if (masraf.tutar>=500&&masraf.tutar<=5000)
            {
                Console.WriteLine("bu masraf ceo tarafından yapılmıştır");
            }
            else if(masraf.tutar>=5000)
            {
                Console.WriteLine("sirketi mi sattın ???");
            }
        }
    }
}
