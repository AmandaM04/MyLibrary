using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool CheckedOut { get; set; }

        [Display (Name ="Library")]
        public int LibraryId { get; set; }

        public Library Library { get; set; }

        [Display(Name = "Patron")]
        public int? PatronId { get; set; }

        public Patron Patron { get; set; }
    }
}
