using ParkingLot.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Domain
{
    public class ParkingSpot
    {
        /// <summary>
        /// Vehicle that is currently been parked in the spot
        /// </summary>
        private readonly Vehicle _vehicle;

        /// <summary>
        /// Level of the spot
        /// </summary>
        private readonly Level _level;

        /// <summary>
        /// The spot type of spot.
        /// </summary>
        private readonly VehicleType _spotType;

        /// <summary>
        /// Row number.
        /// </summary>
        public int Row { get; }

        /// <summary>
        /// Spot number.
        /// </summary>
        public int SpotNumber { get; }

        public ParkingSpot(Level level,
                           VehicleType vehicleType,
                           int row,
                           int spotNumber)
        {
            _level = level;
            _spotType = vehicleType;
            Row = row;
            SpotNumber = spotNumber;
        }

        /// <summary>
        /// Indicate that the vehicle is able to park in the current spot.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public bool IsVehicleFitToSpot(Vehicle vehicle)
        {
            return false;
        }

        /// <summary>
        /// Park the car in the spot and notify the level.
        /// </summary>
        /// <param name="vehicle"></param>
        public void Park(Vehicle vehicle)
        {

        }

        /// <summary>
        /// Removes the parked car and notifieds the level that a new spot is available.
        /// </summary>
        public void RemoveVehicle()
        {

        }
    }
}
