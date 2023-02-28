using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    /* ICarDal method injection ile ICarService' bağlandı böylelikle  tüm işlemlerde _carDal üzerinden iş kurallarından sonra işlemlerin hepsi DataAccessLayer'ı çağırarak işlemlerin gerçekleşmesini sağlayacaktır ...
     
     */


    public class BrandManager : IBrandService
    {
        IBrandDal _carBrandDal;
        public BrandManager(IBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _carBrandDal.Add(brand);
                Console.WriteLine("Kaydetme işlemi başarılıdır");
            }
            else
            {
                Console.WriteLine("Lütfen 2 harften fazla harfi olan markayı giriniz");
            }      
        }
        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }
        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
        List<Brand> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
