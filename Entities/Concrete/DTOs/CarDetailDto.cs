using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public String BrandName { get; set; }
        public String ColorName { get; set; }

    }
}
