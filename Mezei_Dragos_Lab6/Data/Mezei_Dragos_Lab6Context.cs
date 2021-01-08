using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mezei_Dragos_Lab6.Models;

namespace Mezei_Dragos_Lab6.Data
{
    public class Mezei_Dragos_Lab6Context : DbContext
    {
        public Mezei_Dragos_Lab6Context (DbContextOptions<Mezei_Dragos_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Mezei_Dragos_Lab6.Models.Book> Book { get; set; }
    }
}
