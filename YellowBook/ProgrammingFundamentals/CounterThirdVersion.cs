namespace ProgrammingFundamentals
{
    public class CounterThirdVersion
    {
        public int CallCount = 0;

        public void Request()
        {
            CallCount = CallCount + 1;
        }

        public string NumberOfTimesCalled()
        {
            CounterThirdVersion count = new CounterThirdVersion();
            count.Request();
            count.Request();
            count.Request();
            count.Request();
            string numberOfTimesCalled = "Number of times Request is called : " + count.CallCount;
            return numberOfTimesCalled;
        }

    }
}