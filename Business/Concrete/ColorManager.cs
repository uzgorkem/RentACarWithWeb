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


    public class ColorManager : IColorService
    {
        IColorDal _carColorDal;
        public ColorManager(IColorDal colorDal)
        {
            _carColorDal = colorDal;
        }
        List<Color> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
