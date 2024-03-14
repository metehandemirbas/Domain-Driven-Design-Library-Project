using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DDD.Library.Domain.Bases;

namespace DDD.Library.Domain.Entities
{
	/// <summary>
	/// User entity
	/// </summary>
	[Table("Users")]
	public class User : BaseEntity
	{
		/// <summary>
		/// Indicates username of the user
		/// </summary>
		[Required(ErrorMessage = "Username value is required.")]
		[Column(Order = 2)]
		public required string UserName { get; set; }

		/// <summary>
		/// Indicates name of the user
		/// </summary>
		[Required(ErrorMessage = "Name of the user value is required.")]
        [Column(Order = 3)]
        public required string Name { get; set; }

		/// <summary>
		/// Indicates surname of the user
		/// </summary>
		[Required(ErrorMessage = "Surname of the user value is required.")]
		[Column(Order = 4)]
        public required string Surname { get; set; }

		/// <summary>
		/// Indicates password hashed value of the user's password
		/// </summary>
		[Required(ErrorMessage = "Password hash value is required.")]
		[Column(Order = 5)]
        public required byte[] PassworHash { get; set; }

		/// <summary>
		/// Indicates password salt value of the user's password
		/// </summary>
		[Required(ErrorMessage = "Password salt value is required.")]
		[Column(Order = 6)]
        public required byte[] PasswordSalt { get; set; }

		/// <summary>
		/// Indicates e-mail address of the user
		/// </summary>
		[Required(ErrorMessage = "E-mail is required.")]
		[Column(Order = 7)]
        public required string Email { get; set; }

		/// <summary>
		/// Indicates user's activation status
		/// </summary>
		[Required(ErrorMessage = "User's activation status is required.")]
		[Column(Order = 8)]
        public required bool Active { get; set; }
	}
}

