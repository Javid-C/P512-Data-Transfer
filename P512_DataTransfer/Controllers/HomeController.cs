using Microsoft.AspNetCore.Mvc;
using P512_DataTransfer.Models;
using P512_DataTransfer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P512_DataTransfer.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer
                {
                    Id = 1,
                    BrandName = "ASUS",
                    Model = "Predator",
                    Price = 555,
                    Count = 10,
                    Ram = "16GB DDR4"
                },
                new Computer
                {
                    Id = 2,
                    BrandName = "DELL",
                    Model = "XPS15",
                    Price = 430,
                    Count = 5,
                    Ram = "8GB DDR4"
                },
                new Computer
                {
                    Id = 3,
                    BrandName = "Lenova",
                    Model = "ThinkPad gen 3th",
                    Price = 777,
                    Count = 0,
                    Ram = "8GB DDR4"
                },
                new Computer
                {
                    Id = 4,
                    BrandName = "Apple",
                    Model = "Macbook Pro M1",
                    Price = 1500,
                    Count = 2,
                    Ram = "16GB DDR4"
                },
                new Computer
                {
                    Id = 5,
                    BrandName = "HP",
                    Model = "Pavilion",
                    Price = 876,
                    Count = 78,
                    Ram = "16GB DDR4"
                },
                new Computer
                {
                    Id = 6,
                    BrandName = "MSI",
                    Model = "Dragon",
                    Price = 655,
                    Count = 10,
                    Ram = "16GB DDR4"
                },
            };
            List<Card> cards = new List<Card>
            {
                new Card
                {
                    Id =1,
                    Name = "Birkart"
                },
                 new Card
                {
                    Id =2,
                    Name = "Tam"
                },
                  new Card
                {
                    Id =3,
                    Name = "Bolkart"
                }
            };
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Image = "https://media.istockphoto.com/vectors/businesswomen-couple-sitting-at-workplace-desk-business-women-using-vector-id1188392540"
                },
                new Slider
                {
                    Id =2,
                    Image = "https://as1.ftcdn.net/v2/jpg/02/43/52/94/1000_F_243529419_b6QKC5O2E6APGceCPcTmZ8NuLhwmbhe2.jpg"
                },
                new Slider
                {
                    Id =3,
                    Image = "https://image.freepik.com/free-vector/overworked-arab-businesswoman-sitting-workplace-business-woman-freelancer-looking-computer-screen-dark-night-home-office-horizontal-full-length-vector-illustration_48369-39432.jpg"
                }
            };

            HomeVM model = new HomeVM
            {
                Computers = computers,
                Cards = cards,
                Sliders = sliders
            };
            //ViewBag.Computers = computers;
            //ViewData["Computers"] = colmputers;
            return View(model);
        }
    }
}
