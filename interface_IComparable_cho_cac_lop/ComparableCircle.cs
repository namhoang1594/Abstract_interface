using System;
using System.Collections.Generic;
using System.Text;

namespace interface_IComparable_cho_cac_lop
{ 
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() 
        { 

        }
        public ComparableCircle(double radius) : base(radius) 
        {
           
        }
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComparableCircle o)
        {
            if (getRadius() > o.getRadius()) return 1;
            else if (getRadius() < o.getRadius()) return -1;
            else return 1;
        }
    }
}
