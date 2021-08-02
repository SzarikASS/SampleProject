using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using SampleProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Controllers
{

    [ApiController]
    [Route("api/")]

    public class VehicleControllerAPI : ControllerBase
    {
        VehiclesDAO sqlData = new VehiclesDAO();

        [HttpGet]
        public ActionResult <IEnumerable<VehicleModelDTO>> Index()
        {
            List<VehicleModel> vehicles = sqlData.GetAllVehicles();

            List<VehicleModelDTO> vehiclesDTO = new List<VehicleModelDTO>();

            foreach(var vehicle in vehicles)
            {
                vehiclesDTO.Add(new VehicleModelDTO(vehicle));
            }

            return vehiclesDTO;
        }

        [HttpGet("seeker/{searchTerm}")]
        public ActionResult <IEnumerable<VehicleModelDTO>> Seeker(string searchTerm)
        {
          
            List<VehicleModel> vehicles = sqlData.SearchByBrand(searchTerm);

            List<VehicleModelDTO> vehiclesDTO = new List<VehicleModelDTO>();

            foreach(var vehicle in vehicles)
            {
                vehiclesDTO.Add(new VehicleModelDTO(vehicle));
            }

            return vehiclesDTO;
        }

        [HttpGet("ShowOneProduct/{Id}")]
        public ActionResult <VehicleModelDTO> ShowOneProduct(int id)
        {
            VehicleModel vehicle = sqlData.GetVehicleById(id);
            VehicleModelDTO vehicleDTO = new VehicleModelDTO(vehicle);

            return vehicleDTO;

        }

        [HttpPost("InsertProcess")]
        //post action
        //expecting a vehicle in json format in the body of the request
        public ActionResult <int> InsertProcess(VehicleModel vehicle)
        {
            
            int id = sqlData.Insert(vehicle);

            return id;
        }

        [HttpPut("EditProcess")]
        //put request
        //expect json edited object in the body of the request. id number must match the item being modified.
        public ActionResult <VehicleModel> EditProcess(VehicleModel vehicle)
        {

            sqlData.Update(vehicle);

            return sqlData.GetVehicleById(vehicle.Id);
        }


        [HttpDelete("Delete/{Id}")]
        public ActionResult <bool> Delete(int id)
        {

            VehicleModel vehicle = sqlData.GetVehicleById(id);

            bool success = sqlData.Delete(vehicle);

            return success;

        }

        //wersja dla postmana
    }
}
//VehicleModel vehicle = sqlData.GetVehicleById(id);
//VehicleModelDTO vehicleDTO = new VehicleModelDTO(vehicle);

//return vehicleDTO;