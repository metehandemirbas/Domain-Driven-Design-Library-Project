using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DDD.Library.Domain.Bases;

namespace DDD.Library.Domain.Entities
{
	/// <summary>
	/// Genre entity
	/// </summary>
	[Table("Genres")]
	public class Genre : BaseEntity
	{
		/// <summary>
		/// Indicates genre name such as Sci-Fi, Autobiography, Fiction, Documentary
		/// </summary>
		[Required(ErrorMessage = "The genre name is required.")]
		[Column(Order = 2)]
		public required string Name { get; set; }
	}
}