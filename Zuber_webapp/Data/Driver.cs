using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zuber_webapp.Data
{
    public class Driver
    {
        [Key]
        public int Driverid { get; set;}
        public Person Name { get; set;}
        
        
        [ForeignKey("Tripid")]
        public int Trip { get; set; }
        public int Tripid { get; set; }
        
        
        [ForeignKey("Cartypeid")]
        public int CarType { get; set; }
        public int CarTypeid { get; set; }

    }
}
