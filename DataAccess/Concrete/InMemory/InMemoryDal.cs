using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId=1,ColorId=6,BrandId=1,DailyPrice=11,Description="Mercedes iyidir babo",ModelYear=2015},
                new Car{CarId=2,ColorId=5,BrandId=2,DailyPrice=12,Description="Nerde Ford Orda Cort",ModelYear=20156},
                new Car{CarId=3,ColorId=4,BrandId=3,DailyPrice=13,Description="Opel Corsa Toyota CorOna",ModelYear=2017},
                new Car{CarId=4,ColorId=3,BrandId=4,DailyPrice=14,Description="Mercedes iyidir babo",ModelYear=2018},
                new Car{CarId=5,ColorId=2,BrandId=5,DailyPrice=15,Description="Nerde Ford Orda Cort",ModelYear=2019},
                new Car{CarId=6,ColorId=1,BrandId=6,DailyPrice=16,Description="Opel Corsa Toyota CorOna",ModelYear=2010},
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
            Console.WriteLine("Araba Eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(c => c.CarId == car.CarId);
           
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;    
        }

        void ICarDal.GetById(int id)
        {
            Car getById = _cars.SingleOrDefault(c => c.CarId == id);
            Console.WriteLine(getById.Description);
        }

        void IEntityRepository<Car>.GetById(int id)
        {
            Car getById = _cars.SingleOrDefault(c => c.CarId == id);
            Console.WriteLine(getById.Description);
        }
    }
}
