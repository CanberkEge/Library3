using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Identities
{
    public class MyUser : IdentityUser
    {
        public string TCNO { get; set; }
    }
}
