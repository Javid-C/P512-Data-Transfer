using CleanBlog.Models;
using CleanBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            Slider slider = new Slider
            {
                Id = 1,
                Image = "home-bg.jpg",
                Title = "Clean P512 Blog",
                Subtitle = "A Blog Theme by Start Bootstrap"
            };

            List<Post> posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Man must explore, and this is exploration at its greatest",
                    Subtitle = "Man must explore, and this is exploration at its greatest Man must explore, and this is exploration at its greatest Man must explore, and this is exploration at its greatest",
                    Date = new DateTime(2022,02,07)
                },
                new Post
                {
                    Id = 2,
                    Title = "okay Man must explore, and this is exploration at its greatest",
                    Subtitle = "test Man must explore, and this is exploration at its greatest Man must explore, and this is exploration at its greatest Man must explore, and this is exploration at its greatest",
                    Date = new DateTime(2033,02,07)
                }
            };
            HomeVM model = new HomeVM
            {
                Slider = slider,
                Posts = posts
            };
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Post post = new Post
            {
                Id = id,
                Title = "okay",
                Subtitle = "test",
                Date = new DateTime(2077,02,09)
            };
            return View(post);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
