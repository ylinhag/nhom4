using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Nhom4.Models
{
    public class TinTucContext: DbContext
    {

        public TinTucContext(DbContextOptions<TinTucContext> options)
: base(options)
        { }

        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<TinTuc> TinTuc { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P0UQ65L;Database=TinTuc;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


    }
}
