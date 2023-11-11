using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dora_Tarcsafalvi_Lab2.Models;

namespace Dora_Tarcsafalvi_Lab2.Data
{
    public class Dora_Tarcsafalvi_Lab2Context : DbContext
    {
        public Dora_Tarcsafalvi_Lab2Context (DbContextOptions<Dora_Tarcsafalvi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dora_Tarcsafalvi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dora_Tarcsafalvi_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Dora_Tarcsafalvi_Lab2.Models.Author>? Author { get; set; }
    }
}
