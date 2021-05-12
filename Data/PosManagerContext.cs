using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PosManager.Models;

    public class PosManagerContext : DbContext
    {
        public PosManagerContext (DbContextOptions<PosManagerContext> options)
            : base(options)
        {
        }

        public DbSet<PosManager.Models.Category> Category { get; set; }
    }
