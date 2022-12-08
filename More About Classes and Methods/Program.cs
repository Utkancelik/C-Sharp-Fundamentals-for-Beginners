namespace More_About_Classes_and_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */


            /*
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine($"{myOtherCar.Make}, {myOtherCar.Model}," +
                $" {myOtherCar.Year}, {myOtherCar.Color}");

            myOtherCar.Model = "98";

            Console.WriteLine($"{myCar.Make}, {myCar.Model}," +
                $" {myCar.Year}, {myCar.Color}");

            myOtherCar = null;

            //Console.WriteLine($"{myOtherCar.Make}, {myOtherCar.Model}," +
            //    $" {myOtherCar.Year}, {myOtherCar.Color}");

            myCar = null;
            */
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            // You could load from a configuration file,
            // a database, etc.
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color; 
        }
        */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod.");
            //Console.WriteLine(Make);
        }
    }
}