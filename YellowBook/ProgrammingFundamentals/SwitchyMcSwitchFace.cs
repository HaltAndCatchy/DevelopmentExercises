using System;

namespace ProgrammingFundamentals
{
    class SwitchyMcSwitchFace
    {
        public void WindowType()
        {
            string prompt = "Window Type : ";
            
            var readAnotherInt = new MethodLibrary();
            int selection = readAnotherInt.ReadAnotherInt();

            Console.WriteLine(prompt);

            if (selection == 1)
            {
                HandleCasement();
            }
            else
            {
                if (selection == 2)
                {
                    HandleStandard();
                }
                else
                {
                    if (selection == 3)
                    {
                        HandlePatio();
                    }
                    else
                    {
                        if (selection > 3) ;
                        Console.WriteLine("Invalid number");

                    }
                }
            }
        }

        public string HandlePatio()
        {
            return "Patio";
        }

        public string HandleStandard()
        {
            return "Standard";
        }

        public string HandleCasement()
        {
           return "Casement";
        }
    }
}
