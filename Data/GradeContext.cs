using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Grade.Models;

namespace Grade.Data
{
    public class GradeContext : IdentityDbContext
    {
        public GradeContext (DbContextOptions<GradeContext> options)
            : base(options)
        {
        }

        public DbSet<Grade.Models.User> User { get; set; } = default!;

        public DbSet<Grade.Models.Course> Course { get; set; } = default!;
    }
}
