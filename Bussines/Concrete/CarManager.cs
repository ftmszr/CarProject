using Bussines.Abstruct;
using DataAccess.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıCarDal;
        public CarManager(ICarDal ıCarDal)
        {
            _ıCarDal = ıCarDal;
        }
        public List<Car> GetAll()
        {
            return _ıCarDal.GetAll();
        }
    }
}
