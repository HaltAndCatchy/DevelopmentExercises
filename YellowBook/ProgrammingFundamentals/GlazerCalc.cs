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
           double woodLength, glassArea;

           double width = Width();

           double height = Height();

           woodLength = 2 * (width + height) * 3.25;

           glassArea = 2 * (width * height);

            Console.WriteLine ( "The length of the wood is " +
woodLength + " feet" ) ;
            Console.WriteLine( "The area of the glass is " +
glassArea + " square metres" ) ;
           
          
       }

        public static double Height()
        {
            string heightString;
            double height;
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            return height;
        }

        public static double Width()
        {
            string widthString;
            double width;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            return width;
        }

       
    }
}
