using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.DTOs;

namespace DataAccess.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {/*
        Burada ki tüm işlemler EfCore ile bağlantılı yürütülmüştür.
        Bu Kodları tekrar tekrar kodlamamak ve ya modüler bir biçimde tasarlamak için tüm DataAccesLayerlar ICarDal interface'ine bağlandı ...
       */
        public List<CarDetailDto> GetCarDetails()
        {

            using (CarContext context = new CarContext())
            {
                var result = from a in context.Car
                             join b in context.Brand
                             on a.BrandId equals b.Brandid
                             join c in context.Color
                             on a.ColorId equals c.Colorid
                             select new CarDetailDto
                             { 
                                 CarId = a.CarId, BrandName = b.BrandName ,ColorName=c.ColorName
                             };

                return result.ToList();

                
                           
            }


          
        }
    }
}
