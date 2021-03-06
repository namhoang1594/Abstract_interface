﻿using System;
using System.Collections.Generic;
using System.Text;

namespace interface_IComparable_cho_cac_lop
{
    public class Circle
    {
        public double radius;
        public string color = "red";
        public bool filled = true;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
            this.radius = radius;
        }
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public bool GetFilled()
        {
            return filled;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (GetFilled() ? "filled" : "not filled");
        }
    }
}
