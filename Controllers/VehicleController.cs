using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using SampleProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            VehiclesDAO sqlData = new VehiclesDAO();
            return View("Index",sqlData.GetAllVehicles());
        }

        public IActionResult Seeker(string searchTerm)
        {
            VehiclesDAO sqlProducts = new VehiclesDAO();
            List<VehicleModel> products = sqlProducts.SearchByBrand(searchTerm);
            return View("Index", products);
        }

        public IActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public IActionResult Details(int id)
        {
            VehiclesDAO getVehicle = new VehiclesDAO();
            VehicleModel vehicle = getVehicle.GetVehicleById(id);
            return View("Details", vehicle);
        }

        public IActionResult EditForm(int id)
        {
            VehiclesDAO vehicleSql = new VehiclesDAO();
            VehicleModel vehicle = vehicleSql.GetVehicleById(id);

            return View("EditForm", vehicle);
        }

        public IActionResult EditProcess(VehicleModel vehicle)
        {
            VehiclesDAO vehicleSql = new VehiclesDAO();

            vehicleSql.Update(vehicle);
             
            return View("Index", vehicleSql.GetAllVehicles());
        }

        public IActionResult Delete(int id)
        {

            VehiclesDAO vehicleSql = new VehiclesDAO();
            VehicleModel vehicle = vehicleSql.GetVehicleById(id);
            vehicleSql.Delete(vehicle);

            return View("Index", vehicleSql.GetAllVehicles());
        }

        public IActionResult Insert()
        {
            return View("InsertForm");
        }

        public IActionResult InsertProcess(VehicleModel vehicle)
        {
            VehiclesDAO vehicleSql = new VehiclesDAO();
    
            int id = vehicleSql.Insert(vehicle);
            
            return View("Index", vehicleSql.GetAllVehicles());
        }

    }
}
