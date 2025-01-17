﻿using GigHubMosh.Models;
using System.Collections.Generic;

namespace GigHubMosh.ViewModels
{
    public class GigsViewModel
    { 
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
    }

}