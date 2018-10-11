using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Patron
    {
        [Key]
        public int PatronId { get; set; }

        [Required]
        public string FirstName {get; set;}

        [Required]
        public string LastName { get; set; }

        public int LibraryId { get; set; }

        public Library Library { get; set; }

        [Display(Name = "Checked Out Books")]
        public virtual ICollection<Book> CheckedOutBooks { get; set; }


        [Display(Name = "Patrons Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
