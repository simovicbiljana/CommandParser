﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the drone commands
    public class Command
    {
        private String direction { get; set; }
        private int distance { get; set;  }

        private Command(String direction, int distance) {
            this.direction = direction;
            this.distance = distance;
        }

        public override string ToString()
        {
            return "Direction: " + direction + ", Distance: " + distance; 
        }



    }
}
