using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P512_DataTransfer.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Ram { get; set; }
    }
}
