using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        /* Veri tabanına uyumlu olarak hepsinin classları yazıldı 
      Code First değil DbFirst mantığı ile yazımı yapıldı...
      */
        public int Brandid { get; set; }
        public string BrandName { get; set; }
    }
}
