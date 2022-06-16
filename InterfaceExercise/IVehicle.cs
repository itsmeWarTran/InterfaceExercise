using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int numOfWheels { get; set; }
        public string name { get; set; }
        public int numOfSeats { get; set; }
        public bool isConvertable { get; set; }

        public void VehicleDescription();
    }
}
