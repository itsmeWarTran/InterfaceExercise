using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car BMW = new Car();
            BMW.numOfWheels = 4;
            BMW.name = "2022 BMW M3";
            BMW.numOfSeats = 4;
            BMW.isConvertable = true;
            BMW.CompName = "BMW";
            BMW.Income = 3939000;
            BMW.isFast = true;
            BMW.MPH = 120;
            BMW.VehicleDescription();
            BMW.CompanyDescription();
            BMW.CarDescription();

            Console.WriteLine("");
            Console.WriteLine();

            Truck UHAUL = new Truck();
            UHAUL.numOfWheels = 8;
            UHAUL.name = "UHAUL";
            UHAUL.numOfSeats = 2;
            UHAUL.isConvertable = false;
            UHAUL.CompName = "UHAUL";
            UHAUL.Income = 4393243;
            UHAUL.howMuchCarry = 1200;
            UHAUL.hasBox = true;
            UHAUL.VehicleDescription();
            UHAUL.CompanyDescription();
            UHAUL.TruckDescription();

            Console.WriteLine("");
            Console.WriteLine();

            SUV KIA = new SUV();
            KIA.numOfWheels = 4;
            KIA.name = "2022 KIA Sorento";
            KIA.numOfSeats = 6;
            KIA.isConvertable = false;
            KIA.CompName = "KIA";
            KIA.Income = 4838439;
            KIA.peopleCarry = 6;
            KIA.isExpensive = true;
            KIA.VehicleDescription();
            KIA.CompanyDescription();
            KIA.SUVDescription();
        }
    }
}
