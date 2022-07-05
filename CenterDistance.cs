﻿namespace CBox
{
    public struct CenterDistance
    {
        public CenterDistance(double horizontal, double vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        public double Horizontal { get; private set; }
        public double Vertical { get; private set; }
    }
}
