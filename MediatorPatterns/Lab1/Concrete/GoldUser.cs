using MediatorPatterns.Lab1.Abstract;
using MediatorPatterns.Lab1.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatterns.Lab1.Concrete
{
    public class GoldUser:IUser
    {
        string username;
        IChatMediator chatMediator;

        public GoldUser(IChatMediator chatMediator, string userName)
        {
            this.chatMediator = chatMediator;
            this.username = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanici Tipi: Gold\nKullanici Adi: {username}\nAlinanMesaj: {message}");
        }
        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }
    }
}
