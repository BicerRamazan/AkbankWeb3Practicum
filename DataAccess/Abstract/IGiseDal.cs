using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGiseDal
    {
        void Odeme(IEntity tasit);
    }
}
