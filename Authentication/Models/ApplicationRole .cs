using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public bool IsInternal { get; set; }
    }
}
