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
}
