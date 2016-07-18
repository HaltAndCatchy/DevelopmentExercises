using System;

namespace ProgrammingFundamentals
{
    public class Glazer
    {

        public void WindowMeasures()
        {
            double width = Width();
            double height = Height();

            double woodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width + height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadLine();
        }

        public double Height()
        {
            const double maxHeight = 3.0;
            const double minHeight = 0.75;
            var readValue = new ValueReader();

            double windowHeight = readValue.ReadValue("Enter height of window", minHeight, maxHeight);

            Console.WriteLine("Height: " + windowHeight);
            return windowHeight;
        }

        public double Width()
        {
           const double maxWidth = 5.0;
           const double minWidth = 0.5;
           var getValue = new ValueReader();
           
           double windowWidth = getValue.ReadValue(low:minWidth, high:maxWidth, prompt:"Enter width of window: " );
           Console.WriteLine("Width: " + windowWidth);
           return windowWidth;
        }
    }
}