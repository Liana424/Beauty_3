using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beauty_2.Models;

namespace Beauty_2.Data
{
    public class Beauty_2Context : DbContext
    {
        public Beauty_2Context (DbContextOptions<Beauty_2Context> options)
            : base(options)
        {
        }

        public DbSet<Beauty_2.Models.Service> Service { get; set; }

        public DbSet<Beauty_2.Models.Artist> Artist { get; set; }
    }
}
