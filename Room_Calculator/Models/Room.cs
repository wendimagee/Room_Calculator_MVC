using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room_Calculator.Models
{
    public class Room
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double area { get { return Length * Width; } }
        public double perimeter { get {return (Length * 2) + (2 * Width); } }
        public double volume { get { return Length * Height * Width; } }
    }
}
