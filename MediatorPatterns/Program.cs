using MediatorPatterns.Lab1.Abstract;
using MediatorPatterns.Lab1.Concrete;
using MediatorPatterns.Lab1.Mediator.Abstract;
using MediatorPatterns.Lab1.Mediator.Concrete;
using MediatorPatterns.Lab2.Mediator;
using MediatorPatterns.Lab2.Concrete;
using System;
using System.Collections.Generic;
using MediatorPatterns.Lab3;
using MediatorPatterns.Lab4;

namespace MediatorPatterns
{
    internal class Program
    {



        static void Main(string[] args)
        {

            #region Lab1
            //    IChatMediator mediator = new ChatMediator();

            //    IUser ali = new BasicUser(mediator, "Ali");
            //    IUser veli = new BasicUser(mediator, "Veli");
            //    IUser ayse = new GoldUser(mediator, "Ayşe");
            //    IUser fatma = new GoldUser(mediator, "Fatma");

            //    mediator.AddUser(ali);
            //    mediator.AddUser(veli);
            //    mediator.AddUser(ayse);
            //    mediator.AddUser(fatma);

            //    ali.SendMessage("Herkese Merhaba");
            //    ayse.SendMessage("selam ali, nasılsın?");

            //    Console.WriteLine("Hello World!");
            //}
            #endregion

            //CoreMediator coreMediator = new CoreMediator();

            #region lab2

            //Teacher teacher = new Teacher(coreMediator);
            //teacher.Name = "Ercan";

            //Student Arif = new Student(coreMediator);
            //Arif.Name = "Arif";

            //Student Emir = new Student(coreMediator);
            //Emir.Name = "Emir";


            //coreMediator.Students = new List<Student>();
            //coreMediator.Students.Add(Arif);
            //coreMediator.Students.Add(Emir);


            //Arif.SendQuestion("Hocam bu $ işaretini niçin kullanıyoruz? Ben Tl kulllanmak istiyorum");
            //teacher.AnswerQuestion("Parayı veren düdüğü çalar arif. Buralarda tl geçmez", Arif);

            //Emir.SendQuestion("Hocam bu pattern nasıldır..?");
            //teacher.AnswerQuestion("Sabahları kahvaltıdan sonra iyi gider.. ", Emir);
            #endregion


            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            Component3 component3 = new Component3();
            new ConcreteMediator(component1, component2,component3);

            Console.Write("X Firması eşyaları: ");
            component1.DoA();

            Console.Write("Y Firması eşyaları: ");
            component2.DoB();

            Console.Write("Z Firması eşyaları: ");
            component3.DoC();

            Console.WriteLine("-------------------------------------------------");

            islem1 islem1 = new islem1();
            
            
            islem1.gonder();
           
        }

    }
}
