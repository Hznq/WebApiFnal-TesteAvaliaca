using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiFnal.Models;

namespace WebApiFnal.Data
{
    public class WebApiFnalContext : DbContext
    {
        public WebApiFnalContext (DbContextOptions<WebApiFnalContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiFnal.Models.Produtos> Produtos { get; set; } = default!;
    }
}
