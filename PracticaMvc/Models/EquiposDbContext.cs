using System;
using Microsoft.EntityFrameworkCore;
namespace PracticaMvc.Models
{
	public class EquiposDbContext :DbContext
	{
		public EquiposDbContext(DbContextOptions options) :base(options)
		{


		}
        public DbSet<Marcas> marcas { get; set; }
    }
}

