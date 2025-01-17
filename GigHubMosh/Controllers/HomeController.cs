﻿using GigHubMosh.Models;
using GigHubMosh.ViewModels;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GigHubMosh.Controllers
{


    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index(string query = null)
        {
            var upcomingsGigs = _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .Where(g => g.DateTime > DateTime.Now && !g.IsCanceled);

            if (!String.IsNullOrEmpty(query))
            {
                upcomingsGigs = upcomingsGigs
                    .Where(g =>
                            g.Artist.Name.Contains(query) ||
                            g.Genre.Name.Contains(query) ||
                            g.Venue.Contains(query)
                        );
            }

            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingsGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming gigs",
                SearchTerm = query
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}