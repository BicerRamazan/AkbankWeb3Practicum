using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GiseManager : IGiseService
    {
        IGiseDal _giseDal;
        private Otomobil otomobil;

        public GiseManager(IGiseDal giseDal)
        {
            _giseDal = giseDal;
        }

        public GiseManager(Otomobil otomobil)
        {
            this.otomobil = otomobil;
        }

        public void Odeme(IEntity tasit)
        {
            _giseDal.Odeme(tasit);
        }
    }
}
