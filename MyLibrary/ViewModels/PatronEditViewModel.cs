﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class PatronEditViewModel
    {
        public Patron Patron { get; set; }

        //allows a dropdown for libraries
        public List<SelectListItem> Libraries { get; set; }

        public PatronEditViewModel(ApplicationDbContext context)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
        }

        /* created this constructor to redisplay form with information already typed inside. Form will
          allow submission but if modelstate isn't valid, user will get an error message showing what's wrong*/
        public PatronEditViewModel(ApplicationDbContext context, Patron patron)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
            Patron = patron;
        }
    }
}

