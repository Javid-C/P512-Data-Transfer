using P512_DataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P512_DataTransfer.ViewModels
{
    public class HomeVM
    {
        public List<Computer> Computers { get; set; }
        public List<Card> Cards { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
