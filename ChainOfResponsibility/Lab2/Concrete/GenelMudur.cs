using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Lab2.Concrete
{
    public class GenelMudur : MasrafYonetimiBase
    {
        public override void MasrafYonetimi(Masraf masraf)
        {
            if (masraf.tutar>=100 && masraf.tutar<=500)
            {
                Console.WriteLine("Bu masraf genel müdür tarafından yapılmıştır");
            }
            else if (_sonraki!=null)
            {
                _sonraki.MasrafYonetimi(masraf);
            }
        }
    }
}
