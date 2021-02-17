using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto: IDto
    {
        // Dto : İki veya daha fazla tablodan belirli dataları listelemek için kullanırız. 
        // Burada Brand, car ve color tablolarından listelemek istediğimiz verileri yazdık.

        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }

}

