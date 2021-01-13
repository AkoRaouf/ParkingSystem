using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Domain.Vehicles
{
    public class Car : Vehicle
    {
        public Car() : base(VehicleType.Car, spotNeeded:1)
        {

        }
        public override bool CanFitInSpot(ParkingSpot parkingSpot)
        {
            throw new NotImplementedException();
        }
    }
}
