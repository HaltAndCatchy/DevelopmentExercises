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
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthString, heightString;

            do
            {
                Console.Write("Give the width of the window between " +
                              MIN_WIDTH + " and " + MAX_WIDTH + " :");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);

            do
            {
                Console.Write("Give the height of the window between " +
                              MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            woodLength = 2*(width + height)*3.25;
            glassArea = 2*(width + height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadLine();
           
            LoopsControlFlow.While();
            LoopsControlFlow.For();
            PrintingThingsNicely.PlaceholderExample();
        }

        public class LoopsControlFlow
        {
            public static void While()
            {
                int i = 1;
                while (i < 11)
                {
                    Console.WriteLine("Hello");
                    i = i + 1;
                }
                Console.ReadLine();
            }

            public static void For()
            {
                int i;
                for (i = 1; i < 11; i = i + 1)
                {
                    Console.WriteLine("Bird");
                }
                Console.ReadLine();
            }
        }
        
        public class PrintingThingsNicely
        {
            public static void PlaceholderExample()
            {
                int i = 150;
                double f = 1234.56789;
                Console.WriteLine("i: {0} f: {1}", i,f );
                Console.WriteLine("i: {1} f: {0}", f, i );
                Console.ReadLine();
            }
        }
    }
}
