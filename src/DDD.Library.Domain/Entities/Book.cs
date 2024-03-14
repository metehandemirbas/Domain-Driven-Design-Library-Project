using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DDD.Library.Domain.Bases;

namespace DDD.Library.Domain.Entities
{
    /// <summary>
    /// Book entity
    /// </summary>
	[Table("Books")]
	public class Book : BaseEntity
	{
        /// <summary>
        /// Indicates name of the book
        /// </summary>
		[Required(ErrorMessage = "Book name is required.")]
        [StringLength(255, ErrorMessage = "The book name cannot be longer than {0} characters.")]
		[Column(Order = 2)]
		public required string Name { get; set; }

        /// <summary>
        /// Indicates author of the book
        /// </summary>
        [Required(ErrorMessage = "Author name is required.")]
        [StringLength(255, ErrorMessage = "The author name cannot be longer than {0} characters.")]
        [Column(Order = 3)]
        public required string Author { get; set; }

        /// <summary>
        /// Indicates publisher company of the book
        /// </summary>
        [Required(ErrorMessage = "Publisher is required")]
        [Column(Order = 4)]
        [StringLength(255, ErrorMessage = "The publisher name cannot be longer than {0} characters.")]
        public required string Publisher { get; set; }

        /// <summary>
        /// Indicates the year that book is published
        /// </summary>
        [Required(ErrorMessage = "Published year of book is required.")]
        [Column(Order = 5)]
        public required int PublishedYear { get; set; }

        /// <summary>
        /// Indicates the universal ISBN value for the book
        /// </summary>
        [Required(ErrorMessage = "ISBN data is required.")]
        [Column(Order = 6)]
        public required string ISBN { get; set; }

        /// <summary>
        /// Indicates page number of the book
        /// </summary>
        [Required(ErrorMessage = "The page number of the book is required.")]
        [Column(Order = 7)]
        public required int PageNumber { get; set; }

        /// <summary>
        /// Indicates editor fullname of the book
        /// </summary>
        [Required(ErrorMessage = "Editor name is required.")]
        [Column(Order = 8)]
        public required string Editor { get; set; }

        /// <summary>
        /// Indicates translator fullname if the book is a translated book
        /// </summary>
        [Column(Order = 9)]
        public string? Translator { get; set; }

        /// <summary>
        /// Indicates genre id of the book
        /// </summary>
        [Required(ErrorMessage = "Genre is reqired for the book.")]
        [Column(Order = 10)]
        [ForeignKey("GenreId")]
		public virtual Genre Genre { get; set; }
        public required int GenreId { get; set; }


        /// <summary>
        /// Indicates shelf id of the book
        /// </summary>
        [Required(ErrorMessage = "The shelve id is required for the book.")]
        [Column(Order = 11)]
        [ForeignKey("ShelvesId")]
		public virtual Shelf Shelves { get; set; }
        public required int ShelvesId { get; set; }

    }
}

