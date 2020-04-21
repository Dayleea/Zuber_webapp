using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Data;

namespace Zuber_webapp.Models
{
    public class DriverVM
    {
        
        public Person Name { get; set; }

        public int Trip { get; set; }
        public int Tripid { get; set; }
        public int CarType { get; set; }
        public int CarTypeid { get; set; }

    }
}
