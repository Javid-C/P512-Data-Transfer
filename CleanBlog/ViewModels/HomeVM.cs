using CleanBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }
        public List<Post> Posts { get; set; }
    }
}
