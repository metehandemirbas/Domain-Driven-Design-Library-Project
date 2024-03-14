using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DDD.Library.Domain.Bases;

namespace DDD.Library.Domain.Entities
{
	/// <summary>
	/// Shelf entity
	/// </summary>
	[Table("Shelves")]
	public class Shelf : BaseEntity
	{
		/// <summary>
		/// Indicates shelf name like A-1, B-1, C-4
		/// </summary>
		[Required(ErrorMessage = "Shelf name is required.")]
		[Column(Order = 2)]
		public required string Name { get; set; }
	}
}

