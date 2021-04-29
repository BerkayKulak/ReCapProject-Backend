using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    // database nesnesi olmadığ için : IEntity diyemeyiz çünkü bu sen bir veritabanı tablosusun demektir.
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }

        public int BrandId { get; set; }
        public int ColorId { get; set; }

        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
