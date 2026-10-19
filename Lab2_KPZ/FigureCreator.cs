using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_KPZ
{
    public abstract class FigureCreator
    {
        public abstract Figure CreateFigure();

        public string GetFigureString()
        {
            Figure figure = CreateFigure();

            return figure.FigureType.ToString();
        }
    }

    public class CreateCircle : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return new Circle();
        }
    }

    public class CreateSquare : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return new Square();
        }
    }

    public class CreateRectangle : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return new Rectangle();
        }
    }

    public class CreateTriangle : FigureCreator
    {
        public override Figure CreateFigure()
        {
            return new Triangle();
        }
    }
}
