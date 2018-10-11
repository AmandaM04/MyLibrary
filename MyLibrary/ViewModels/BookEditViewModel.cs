using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class BookEditViewModel
    {
        public Book Book { get; set; }

        //allows a dropdown for libraries
        public List<SelectListItem> Libraries { get; set; }

        //allows a dropdown for patrons
        public List<SelectListItem> Patrons { get; set; }

        public BookEditViewModel(ApplicationDbContext context)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();

            Patrons = context.Patron.Select(patron =>
            new SelectListItem { Text = patron.FirstName + patron.LastName, Value = patron.PatronId.ToString() }).ToList();
        }

        /* created this constructor to redisplay form with information already typed inside. Form will
          allow submission but if modelstate isn't valid, user will get an error message showing what's wrong*/
        public BookEditViewModel(ApplicationDbContext context, Book book)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
            Book = book;
        }
    }
}
