namespace Task_1.Figure
{
    using System;

    public class Figure
    {
        public double width, height;
        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Figure GetFigureToFitInWhenRotated(Figure figure, double angleOfRotation)
        {
            double width = Math.Abs(Math.Cos(angleOfRotation)) * figure.width +
                           Math.Abs(Math.Sin(angleOfRotation)) * figure.height;
            double height = Math.Abs(Math.Sin(angleOfRotation)) * figure.width +
                            Math.Abs(Math.Cos(angleOfRotation)) * figure.height;
            Figure wrapperFigure = new Figure(width, height);

            return wrapperFigure;
        }
    }
}
