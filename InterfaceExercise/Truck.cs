using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
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

        public double howMuchCarry { get; set; }
        public bool hasBox { get; set; }

        public void TruckDescription()
        {
            Console.WriteLine($"This truck can carry {howMuchCarry}lbs.");
            Console.WriteLine("Has Box: "+hasBox);
        }
    }
}
