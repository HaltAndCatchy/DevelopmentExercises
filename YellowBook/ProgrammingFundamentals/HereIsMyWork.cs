using System;
using ProgrammingFundamentals;

namespace YellowBook
{
    public class HereIsMyWork
    {
        public static void Main()
        {
            //var showBooleanWork = new Booleans();
            //showBooleanWork.SomeBools();
            //showBooleanWork.ShortCircuiting();
            //var memberExamples = new MemberExample();
            //memberExamples.YetAnotherMethod();
            //var showRecursionWork = new RecursionExample();
            //showRecursionWork.Caller();
            //var showFizzBuzzWork = new FizzBuzz();
            //showFizzBuzzWork.BaseMethod();
            var showCallMe = new CallMe();
            showCallMe.NumberOfTimesCalled();
            
            Console.ReadLine();
        }

        public void CallMyDemos(string prompt, double low, double high)
        {

            ////var loopControlFlow = new LoopsControlFlow();
            ////loopControlFlow.While();
            ////loopControlFlow.For();
            ////var printingThingsNicely = new PrintingThingsNicely();
            ////printingThingsNicely.PlaceholderExample();

            var methodDemo = new MethodDemo();
            methodDemo.CalltheOtherOne();

            var returnDemo = new ReturnDemo();
            returnDemo.ReturningDemo();
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
                string A , B;
                A = "TinkyWinky";
                B = "Dipsy";
                
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
