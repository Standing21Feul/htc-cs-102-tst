﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarWarsRobot : Robot
    {
        int InNumberOfMovies { get; set; }

        public StarWarsRobot(int inNumberOfMovies, double strideLength, int numLegs)
        {
            InNumberOfMovies = inNumberOfMovies;
            StrideLength = strideLength;
            NumLegs = numLegs;
        }
    }
}