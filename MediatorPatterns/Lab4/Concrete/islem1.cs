using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatterns.Lab4
{
    internal class islem1:mediatoralici
    {
        public void gonder()
        {
            Console.WriteLine("Parayı girin: ");
            int para = Convert.ToInt32(Console.ReadLine());
            
            if (para>100000)
            {
                int para2 = para * 3 / 100;
                Console.WriteLine($"Alıcı, konutun fiyatı 100.000 Tl'den büyük olduğu için satıcıya {para-para2} tl gönderiyor ve emlakçıya {para2} tl komisyon ödüyor\n");
            }
            else if (para<100000)
            {
                int para3 = para * 10 / 100;
                Console.WriteLine($"Alıcı, konutun fiyatı 100.000 Tl'den küçük olduğu için satıcıya {para} tl gönderiyor ve emlakçıya cebinden {para3} tl komisyon ödüyor");
            }
            
            


        }
    }
}