﻿using System;

namespace Cars
{
    public class Seat : Car
    {
        public Seat(string model, string color) 
            : base(model, color)
        {

        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}" + Environment.NewLine + Start() + Environment.NewLine + Stop() ;
        }
    }
}
