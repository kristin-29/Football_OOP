﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class Football_player : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public Football_player(string name, int number, int age, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
