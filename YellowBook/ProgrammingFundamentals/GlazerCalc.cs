using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingFundamentals;

namespace YellowBook
{
    public class GlazerCalc
    {
        public static void Main()
        {
            //double width, height, woodLength, glassArea;

            //const double MAX_WIDTH = 5.0;
            //const double MIN_WIDTH = 0.5;
            //const double MAX_HEIGHT = 3.0;
            //const double MIN_HEIGHT = 0.75;

            //string widthString, heightString;

            //do
            //{
            //    Console.Write("Give the width of the window between " +
            //                  MIN_WIDTH + " and " + MAX_WIDTH + " :");
            //    widthString = Console.ReadLine();
            //    width = double.Parse(widthString);
            //} while (width < MIN_WIDTH || width > MAX_WIDTH);

            //do
            //{
            //    Console.Write("Give the height of the window between " +
            //                  MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
            //    heightString = Console.ReadLine();
            //    height = double.Parse(heightString);
            //} while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            //woodLength = 2*(width + height)*3.25;
            //glassArea = 2*(width + height);

            //Console.WriteLine("The length of the wood is " + woodLength + " feet");
            //Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            //Console.ReadLine();

            ////var loopControlFlow = new LoopsControlFlow();
            ////loopControlFlow.While();
            ////loopControlFlow.For();
            ////var printingThingsNicely = new PrintingThingsNicely();
            ////printingThingsNicely.PlaceholderExample();

            var methodDemo = new MethodDemo();
            methodDemo.CalltheOtherOne();
        }

        public class LoopsControlFlow
        {
            public void While()
            {
                int i = 1;
                while (i < 11)
                {
                    Console.WriteLine("Hello");
                    i = i + 1;
                }
                Console.ReadLine();
            }

            public void For()
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
            public void PlaceholderExample()
            {
                int i = 150;
                double f = 1234.56789;
                string A , B, C, D;
                A = "TinkyWinky";
                B = "Dipsy";
                C = "LaaLaa";
                D = "Po";
                
                Console.WriteLine("i: {0} f: {1}", i,f );
                Console.WriteLine("i: {1:#,##0} f: {0:##,##0.00}", f, i );
                
                Console.WriteLine("Here are my column formatting examples: ");
                Console.WriteLine("i:{0,10:0} f:{1,15:0.00}", i, f);
                Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", i, f );
                Console.WriteLine("A: {0,-10} B: {1,-10}", A, B);
                Console.ReadLine();
            }
        }
    }
}
