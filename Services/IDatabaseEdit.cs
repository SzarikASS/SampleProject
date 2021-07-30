using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Services
{
    interface IDatabaseEdit
    {


        List<VehicleModel> GetAllVehicles();
        List<VehicleModel> VehiclesProducts(string searchTerm);
        VehicleModel GetVehicleById(int id);

        int Insert(VehicleModel vehicle);
        int Update(VehicleModel vehicle);
        int Delete(VehicleModel vehicle);


    }
}
