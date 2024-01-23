using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singletons
{
    public class VehicleMemoryColection
    {
        private static VehicleMemoryColection _instance;
        public ICollection<Vehicle> Vehicles { get; set; }

        public VehicleMemoryColection()
        {
            Vehicles = new List<Vehicle>();
        }

        public static VehicleMemoryColection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VehicleMemoryColection();
                }
                return _instance;
            }
        }
    }
}
