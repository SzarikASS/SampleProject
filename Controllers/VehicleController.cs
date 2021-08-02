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

        VehiclesDAO sqlData = new VehiclesDAO();

        public IActionResult Index()
        {
            return View("Index",sqlData.GetAllVehicles());
        }

        public IActionResult Seeker(string searchTerm)
        {
            List<VehicleModel> products = sqlData.SearchByBrand(searchTerm);
            return View("Index", products);
        }

        public IActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public IActionResult Details(int id)
        {
            VehicleModel vehicle = sqlData.GetVehicleById(id);
            return View("Details", vehicle);
        }

        public IActionResult EditForm(int id)
        {
            VehicleModel vehicle = sqlData.GetVehicleById(id);

            return View("EditForm", vehicle);
        }

        public IActionResult EditProcess(VehicleModel vehicle)
        {
            sqlData.Update(vehicle);
             
            return View("Index", sqlData.GetAllVehicles());
        }

        public IActionResult Delete(int id)
        {
            VehicleModel vehicle = sqlData.GetVehicleById(id);
            sqlData.Delete(vehicle);

            return View("Index", sqlData.GetAllVehicles());
        }

        public IActionResult Insert()
        {
            return View("InsertForm");
        }

        public IActionResult InsertProcess(VehicleModel vehicle)
        {
            int id = sqlData.Insert(vehicle);
            
            return View("Index", sqlData.GetAllVehicles());
        }

        public IActionResult ShowOneProductJSON (int id)
        {
            return Json(sqlData.GetVehicleById(id));
        }

        public IActionResult EditProcessReturnPartial(VehicleModel vehicle)
        {
            sqlData.Update(vehicle);

            return PartialView("_vehicle", vehicle);
        }
    }
}
