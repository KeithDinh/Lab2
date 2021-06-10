using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        private double length = 0;
        private double breadth = 0;
        private double height = 0;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public double getBreadth()
        {
            return breadth;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getHeight()
        {
            return height;
        }
    }
}
