﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DodoPetStore.Models.Data;
using System.Web.Mvc;

namespace DodoPetStore.Models.ViewModels.Pages
{
    public class PageVM
    {
        public PageVM()
        {

        }

        public PageVM(PageDTO row)
        {
            Id = row.Id;
            Title = row.Title;
            Slug = row.Slug;
            Body = row.Body;
            Sorting = row.Sorting;
            HasSidebar = row.HasSidebar;
        }

        //Properties
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public string Slug { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        [AllowHtml]
        public string Body { get; set; }

        public int Sorting { get; set; }

        public bool HasSidebar { get; set; }


    }
}