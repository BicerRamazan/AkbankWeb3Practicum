using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Otobus:IEntity
    {
        public int HgsNumarasi { get; set; }
        public string AdSoyad { get; set; }
        public int AracSinifi { get; set; }
        public DateTime GecisTarihi { get; set; }
        public decimal Bakiye { get; set; }
    }
}
