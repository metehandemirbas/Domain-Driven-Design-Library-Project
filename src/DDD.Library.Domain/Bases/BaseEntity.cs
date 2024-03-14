using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Library.Domain.Bases
{
	/// <summary>
	/// Base entity for all entities used in project
	/// </summary>
	public class BaseEntity
	{
        /// <summary>
        /// Entity Id number which is unique
        /// </summary>
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		/// <summary>
		/// Creation time of the row
		/// </summary>
		public DateTime CreatedDate { get; set; }

		/// <summary>
		/// Indicates user who created the row
		/// </summary>
		public required string CreatedBy { get; set; }

		/// <summary>
		/// Indicates date of update
		/// </summary>
		public DateTime UpdatedDate { get; set; }

		/// <summary>
		/// Indicates user who updated the row
		/// </summary>
		public string UpdatedBy { get; set; }
	}
}

