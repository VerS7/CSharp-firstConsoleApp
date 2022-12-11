using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    abstract class Figure
    {
        public double Perimeter;
        public double Square;
        public abstract void countPerimeter();
        public abstract void countSquare();
    }
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override void countPerimeter()
        {
            this.Perimeter = 2 * Math.PI * Radius;
        }
        public override void countSquare()
        {
            this.Square = Math.PI * Math.Pow(Radius, 2);
        }
    }
    class Rectangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public override void countPerimeter()
        {
            this.Perimeter = 2 * (a + b);
        }
        public override void countSquare()
        {
            this.Square = a * b;
        }
    }
    class Triagle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public override void countPerimeter()
        {
            this.Perimeter = a + b + c;
        }
        public override void countSquare()
        {
            countPerimeter();
            var p = this.Perimeter / 2;
            this.Square = Math.Sqrt((p*(p-a)*(p-b)*(p-c)));
        }
    }
    class Trapezoid : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double h { get; set; }
        public override void countPerimeter()
        {
            this.Perimeter = a + b + c + d;
        }
        public override void countSquare()
        {
            this.Square = ((a+b) * 1/2) * h;
        }
    }
}
