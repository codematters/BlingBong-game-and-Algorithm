﻿using System;
using PartOne;
using PartTwo;

namespace FinalProject
{


    class Program
    {
        static void Main(string[] args)
        { 
            BlingGame j = new BlingGame();

            j.PrintNum();

            SequenceNum p = new SequenceNum();

            p.PrintSequence(8);

        }
    }
}
