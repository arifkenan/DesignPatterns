using Methods2.Ornek1.Abstract;
using Methods2.Ornek1.Creater;
using System;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iproduct product;
            ProductCreater productCreater = new ProductCreater();
            for (int i = 1; i < 13; i++)
            {
                product = productCreater.FactoryMethod(i);
                Console.WriteLine(product.ShipFrom());
            }
        }
    }
}