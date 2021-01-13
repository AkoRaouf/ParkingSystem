using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Domain.Vehicles
{
    public abstract class Vehicle
    {
        protected List<ParkingSpot> _parkingSpots = new List<ParkingSpot>();

        protected VehicleType VehicleType { get; }

        protected int SpotNeeded { get; }

        public Vehicle(VehicleType vehicleType,
                       int spotNeeded)
        {
            VehicleType = vehicleType;
            SpotNeeded = spotNeeded;
        }

        protected void ParkingSpots(IList<ParkingSpot> parkingSpots)
        {
            _parkingSpots.AddRange(parkingSpots);
        }

        protected void ClearParkingSpots()
        {
            _parkingSpots = new List<ParkingSpot>();
        }

        public abstract bool CanFitInSpot(ParkingSpot parkingSpot);
    }
}
