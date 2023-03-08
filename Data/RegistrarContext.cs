using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;

    public class RegistrarContext : DbContext
    {
        public RegistrarContext (DbContextOptions<RegistrarContext> options)
            : base(options)
        {
        }

        public DbSet<Registrar.Models.Course> Course { get; set; } = default!;

        public DbSet<Registrar.Models.Enrollment> Enrollment { get; set; } = default!;
    }
