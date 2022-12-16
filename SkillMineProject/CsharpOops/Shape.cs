using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    //Abstract class
    abstract public class Shape
    {
        public abstract void CalculateRectangle();
    }

    public class Circle : Shape
    {
        private int r;
        private double circlearea;

        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateRectangle()
        {
            circlearea = 3.14 * r * r;
        }
 
        public override string ToString()
        {
            return $"area of circle--> {circlearea}";
        }

    }
    public class Rectangle : Shape
    {
        private int l;
        private int w;
        private double area;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        public override void CalculateRectangle()
        {
            area = l * w;
        }
        public override string ToString()
        {
            return $"Area of rectangle--> {area}" ;

        }
    }

    public class Triangle : Shape
    {
        private int b;
        private int h;
        private double areatriangle;
        public Triangle(int b, int h)
        {
            this.b = b;
            this.h = h;
        }
        public override void CalculateRectangle()
        {
            areatriangle = ((0.5) * b * h);
        }
        public override string ToString()
        {
            return $"Area Of Triangle --> {areatriangle}";
        }
    }
}
