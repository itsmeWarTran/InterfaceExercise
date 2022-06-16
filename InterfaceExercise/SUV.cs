using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public int numOfWheels { get; set; }
        public string name { get; set; }
        public int numOfSeats { get; set; }
        public bool isConvertable { get; set; }

        public void VehicleDescription()
        {
            Console.WriteLine($"The vehicle's name is {name}. It has {numOfWheels} wheelsand {numOfSeats} seats" +
                $" is convertable: {isConvertable}");
        }


        public string CompName { get; set; }
        public double Income { get; set; }

        public void CompanyDescription()
        {
            Console.WriteLine($"The company name is {CompName}. The annual income is ${Income}");
        }


        public int peopleCarry { get; set; }
        public bool isExpensive { get; set; }
        public void SUVDescription()
        {
            Console.WriteLine($"This SUV carrys {peopleCarry} people");
            Console.WriteLine("Is expensive: " + isExpensive);
        }
    }
}
