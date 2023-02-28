using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    /* ICarDal method injection ile ICarService' bağlandı böylelikle  tüm işlemlerde _carDal üzerinden iş kurallarından sonra işlemlerin hepsi DataAccessLayer'ı çağırarak işlemlerin gerçekleşmesini sağlayacaktır ...
     
     */
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {            
           return _carDal.GetAll();            
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();

        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }
        public List<Car> GetCarsById(int id)
        {
            return _carDal.GetAll(p => p.CarId == id);
        }
    }
}
