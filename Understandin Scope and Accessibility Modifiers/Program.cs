namespace Understandin_Scope_and_Accessibility_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.DoSomething();
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        private string HelperMethod()
        {
            return "Hello World";
        }
    }
}