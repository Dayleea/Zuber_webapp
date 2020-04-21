using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zuber_webapp.Data
{
    public class Admin : IdentityUser
    {
        public Person Name { get; set; }
        public DateTime DateStarted { get; set; }

    }
}
