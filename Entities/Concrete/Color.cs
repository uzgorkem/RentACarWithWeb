using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color:IEntity
    {/* Veri tabanına uyumlu olarak hepsinin classları yazıldı 
      Code First değil DbFirst mantığı ile yazımı yapıldı...
      */
        public int Colorid { get; set; }
        public String ColorName { get; set; }
    }
}
