﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    internal class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt.");
        }
        
        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }
    }
}
