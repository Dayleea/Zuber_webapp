using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zuber_webapp.Data
{
    public class Trip
    {
        [Key]
        public int Tripid { get; set; }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public decimal Cost { get; set; }


        [ForeignKey("Customerid")]
        public string Customer { get; set; }
        public string Customerid { get; set; }
                
        [ForeignKey("Driverid")]
        public int Driver { get; set; }
        public int Driverid { get; set; }
        
        public DateTime DateShedule { get; set; }
        public int Cartypeid { get; set; }

    }
}
