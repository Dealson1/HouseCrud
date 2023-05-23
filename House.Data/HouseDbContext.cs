using Microsoft.EntityFrameworkCore;
using House.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House.Core.Dto;

namespace House.Data
{
    public class HouseDbContext : DbContext
    {
        public HouseDbContext(DbContextOptions<HouseDbContext> options) : base(options) { }

        public DbSet<HouseDomain> House { get; set; }

    }
}
