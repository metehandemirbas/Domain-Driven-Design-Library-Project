using System;
using DDD.Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DDD.Library.Infrastructure.DataContext
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
		{
			this.Database.EnsureCreated();
		}

		public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<Genre> Genres { get; set; }
		public virtual DbSet<Shelf> Shelves { get; set; }
		public virtual DbSet<User> Users { get; set; }
    }
}

