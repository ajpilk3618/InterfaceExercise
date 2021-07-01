using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehihcle, ICompany
    {
        public int NumOfWheels { get; set; }
        public string FuelType { get; set; }
        public int MPG { get; set; }
        public int NumOfDoors { get; set; }
        public string TransmissionType { get; set; }


        public string Logo { get; set; }
        public string Reputation { get; set; }
        public string CompanyName { get; set; }
    }
}
