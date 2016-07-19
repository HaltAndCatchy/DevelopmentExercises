using System;


namespace ProgrammingFundamentals
{
    class ScopeExamples
    {
        public void UsingScope()
        {
            {
                int i;
            }
            {
                int i;
                {
                    int j;
                }
            }
        }
    }

    public class MemberExample
    {
        public int member = 0;

        public void OtherMethod()
        {
            member = 99;
        }

        public void YetAnotherMethod()
        {
            Console.WriteLine("member is : " + member);
            OtherMethod();
            Console.WriteLine("member is now: " + member);
            Console.ReadLine();
        }
    }
}
