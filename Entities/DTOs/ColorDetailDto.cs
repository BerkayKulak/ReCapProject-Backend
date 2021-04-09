using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ColorDetailDto : IDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
    }
}
