using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zuber_webapp.Data
{
    public class CarType 
    {
        [Key]
        public int CarTypeid { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarVIN { get; set; }
        public string CarColor { get; set; }

    }
}
