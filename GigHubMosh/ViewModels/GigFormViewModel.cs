﻿using GigHubMosh.Models;
using System.Collections.Generic;

namespace GigHubMosh.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date  { get; set; }

        public string Time  { get; set; }

        public int Genre { get; set; }


        public IEnumerable<Genre> Genres { get; set; }
    }
}