using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Domain.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus() : base(VehicleType.Bus, spotNeeded: 5)
        {
          
        }

        public override bool CanFitInSpot(ParkingSpot parkingSpot)
        {
            throw new NotImplementedException();
        }
    }
}
