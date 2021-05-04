using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstruct
{
    public interface ICarService 
    {
        List<Car> GetAll();
    }
}
