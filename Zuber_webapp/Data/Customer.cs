using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zuber_webapp.Data
{
    public class Customer: IdentityUser
      {
        public Person Name { get; set; }

        [ForeignKey("Tripid")]
        public int Trip { get; set; }
        public int Tripid { get; set; }


    }
}
