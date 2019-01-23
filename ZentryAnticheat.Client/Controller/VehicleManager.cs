using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ZentryAnticheat.Client.Controller
{
    public class VehicleManager
    {
            
        private int[] vehicleIdInterzise = new int[1]
        {
            21321321
        };
        
        public void VehicleScan()
        {
            foreach (Vehicle allVehicle in World.GetAllVehicles())
            {
                int entityModel = API.GetEntityModel(allVehicle.Handle);
                if (API.DoesEntityExist(allVehicle.Handle))
                {
                    if (((IEnumerable<int>) this.vehicleIdInterzise).Contains<int>(entityModel))
                    {
                        allVehicle.Delete();
                    }
                }
            }
            
        }
    }
}