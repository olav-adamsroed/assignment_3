using System;
using System.Collections.Generic;
using System.Text;
using assignment_3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using assignment_3.Controllers;
using assignment_3.Models;

namespace assignment_3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Guestbook> Guests { get; set; }
    }
    
}
