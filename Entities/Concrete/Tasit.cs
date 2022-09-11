using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Tasit:IEntity
    {
        public int HgsNumarasi { get; set; }
        public string AdSoyad { get; set; }
        public int AracSinifi { get; set; }
        public DateTime GecisTarihi { get; set; }
        public decimal Bakiye { get; set; }
    }
}
