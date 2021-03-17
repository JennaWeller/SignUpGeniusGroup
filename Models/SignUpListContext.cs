using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    //SignUpListContext inherits from the DbContext
    public class SignUpListContext : DbContext
    {
        public SignUpListContext(DbContextOptions<SignUpListContext> options) : base(options)
        {

        }

        public DbSet<SignUpItem> signUps { get; set; }

        public DbSet<SignUpTime> signUpTimes { get; set; }
    }
}
