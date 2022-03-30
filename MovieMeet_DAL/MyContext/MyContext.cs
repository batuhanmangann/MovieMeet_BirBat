using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MovieMeet_EL.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMeet_DAL.MyContext
{
    public class MyContext : IdentityDbContext<AppUser,AppRole,string>
    {
    }
}
