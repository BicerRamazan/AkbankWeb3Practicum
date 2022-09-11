using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GiseManager manager = new GiseManager(new Otomobil{AdSoyad="Ali Yılmaz",AracSinifi=1,Bakiye=100,GecisTarihi=DateTime.Now,HgsNumarasi=11223344});
            
        }
    }
}
