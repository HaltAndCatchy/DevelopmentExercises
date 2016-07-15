using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowBook
{
    public class GlazerCalc
    {
       public static void Main()
       {
           Console.Write("Give the width of the window : ");



           double height = Height();
           double width = Width();
           
           //const double MAX_WIDTH = 5.0;
           //const double MIN_WIDTH = 0.5;
           //const double MAX_HEIGHT = 3.0;
           //const double MIN_HEIGHT = 0.75;
           
           double woodLength = 2 * (width + height) * 3.25;
           double glassArea = 2 * (width * height);

           Console.WriteLine ( "The length of the wood is " + woodLength + " feet" ) ;
           Console.WriteLine( "The area of the glass is " + glassArea + " square metres" ) ;
           Console.ReadLine();


       }

        public static double Height()
        {
            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);
            return height;
        }

        public static double Width()
        {
            string widthString = Console.ReadLine();
            double width = double.Parse(widthString);
            return width;
        }

       
    }
}
