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

        public string FirstName {get; set;}

        public string LastName { get; set; }

        public virtual ICollection<Library> Libraries { get; set; }

        [Display(Name = "Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }

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
