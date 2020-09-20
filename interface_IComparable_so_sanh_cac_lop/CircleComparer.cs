using System;
using System.Collections.Generic;
using System.Text;

namespace interface_IComparable_so_sanh_cac_lop
{
    public class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getRadius() > c2.getRadius()) return 1;
            else if (c1.getRadius() < c2.getRadius()) return -1;
            else return 0;
        }
    }
}
