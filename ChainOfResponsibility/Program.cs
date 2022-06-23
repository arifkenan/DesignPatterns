using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;
using ChainOfResponsibility.Lab2.Concrete;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //PlayerHandler mp3Player = new Mp3Player();
            //PlayerHandler mp4Player = new Mp4Player();
            //PlayerHandler aviPlayer = new AviPlayer();


            //mp3Player.NextHandler = aviPlayer;
            //aviPlayer.NextHandler = mp4Player;


            //mp3Player.Player("Video.avi");
            //mp3Player.Player("Video.mp3");
            //mp3Player.Player("Video.mp4");
            //mp3Player.Player("Video.xxx");

            //Console.WriteLine("Hello World!");


            Yonetici yonetici = new Yonetici();
            GenelMudur genelmudur = new GenelMudur();
            CEO ceo = new CEO();

            yonetici.MasrafMerkezi(genelmudur);
            genelmudur.MasrafMerkezi(ceo);

            List<Masraf> masraflar = new List<Masraf>
            {
                new Masraf{tutar=70},
                new Masraf{tutar=250},
                new Masraf{tutar=4500},
                new Masraf{tutar=50000},
            };

            foreach (Masraf masraf in masraflar)
            {
                yonetici.MasrafYonetimi(masraf);
            }
        }
    }
}