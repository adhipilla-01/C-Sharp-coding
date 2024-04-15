using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDay_03_ShapeAreas
{
    internal class Area
    {
        private double Length;
        private double Width;
        private double Radius;

        public Area(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public Area(double Radius)
        {
            this.Radius = Radius;
        }
        public double RectangleArea()
        {
            return 2 * Length * Width;
        }
        public double CircleArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
