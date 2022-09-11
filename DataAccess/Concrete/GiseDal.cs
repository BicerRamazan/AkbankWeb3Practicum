using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class GiseDal : IGiseDal
    {
        public void Odeme(IEntity tasit)
        {
            Console.WriteLine("Ödeme alındı");
        }
    }
}
