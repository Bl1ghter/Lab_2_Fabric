using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KPZ
{
    public interface Figure
    {
        FigureType FigureType { get; set; }

        Figure GetFigure();
    }

    public enum FigureType
    {
        Circle,
        Square,
        Rectangle,
        Triangle
    }

    public class Circle : Figure
    {
        public FigureType FigureType { get; set; } = FigureType.Circle;
        public Figure GetFigure()
        {
            return this;
        }
    }

    public class Square : Figure
    {
        public FigureType FigureType { get; set; } = FigureType.Square;

        public Figure GetFigure()
        {
            return this;
        }
    }

    public class Rectangle : Figure
    {
        public FigureType FigureType { get; set; } = FigureType.Rectangle;

        public Figure GetFigure()
        {
            return this;
        }
    }

    public class Triangle : Figure
    {
        public FigureType FigureType { get; set; } = FigureType.Triangle;

        public Figure GetFigure()
        {
            return this;
        }
    }
}
