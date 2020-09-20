﻿using System;
using System.Collections.Generic;
using System.Text;

namespace class_Animal_interface_Edible
{
    class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string HowToEat()
        {
            return "could be fried";
        }
    }
}
