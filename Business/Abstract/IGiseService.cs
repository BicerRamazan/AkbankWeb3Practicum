using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGiseService
    {
        void Odeme(IEntity tasit);
    }
}
