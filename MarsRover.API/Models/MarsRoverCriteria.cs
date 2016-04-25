using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarsRover;

namespace MarsRover.API.Models
{
    public class MarsRoverCriteria
    {
        public int StartingX { get; set; }
        public int StartingY { get; set; }
        public Direction Direction { get; set; }
        public string Movements { get; set; }
    }
}