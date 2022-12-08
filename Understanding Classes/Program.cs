namespace Understanding_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

            Console.WriteLine("{0}", myCar.DetermineTheMarketValue());
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);
        }

        //private static decimal DetermineMarketValue(Car car)
        //{
        //    decimal carValue = 100.0M;

        //    return carValue;
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public decimal DetermineTheMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;
            }


            return carValue;
        }
        //public Car(string _Make, string _Model, int _Year, string _Color) 
        //{
        //    Make = _Make;
        //    Model = _Model;
        //    Year = _Year;
        //    Color = _Color;
        //}
    }
}

