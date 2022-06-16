using System;
namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car()
        {
        }

        public int numOfWheels { get; set; }
        public string name { get; set; }
        public int numOfSeats { get; set; }
        public bool isConvertable { get; set; }

        public void VehicleDescription()
        {
            Console.WriteLine($"The vehicle's name is {name}. It has {numOfWheels} wheelsand {numOfSeats} seats" +
                $"Is convertable: {isConvertable}");
        }


        public string CompName { get; set; }
        public double Income { get; set; }

        public void CompanyDescription()
        {
            Console.WriteLine($"The company name is {CompName}. The annual income is ${Income}");
        }


        public bool isFast { get; set; }
        public int MPH { get; set; }

        public void CarDescription()
        {
            Console.WriteLine("Is Fast:" + isFast);
            Console.WriteLine("MPH: " + MPH);
        }


    }
}
