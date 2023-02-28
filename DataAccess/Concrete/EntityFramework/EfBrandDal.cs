using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{/*
        Burada ki tüm işlemler EfCore ile bağlantılı yürütülmüştür.
        Bu Kodları tekrar tekrar kodlamamak ve ya modüler bir biçimde tasarlamak için tüm DataAccesLayerlar ICarDal interface'ine bağlandı ...
 */

    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarContext>, IBrandDal
    {
       
    }
}
