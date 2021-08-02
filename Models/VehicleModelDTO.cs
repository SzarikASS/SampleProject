using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class VehicleModelDTO
    {
        
        public int Id { get; set; }

        [Required]
        [DisplayName("Car brand")]
        [StringLength(30)]
        public string VehicleBrand { get; set; }
        [Required]
        [DisplayName("Model name")]
        [StringLength(30)]
        public string ModelName { get; set; }
        [Required]
        [DisplayName("Producer price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string PriceString { get; set; }

        [Required]
        [DisplayName("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public decimal Tax { get; set; }

        public VehicleModelDTO(int id, string vehicleBrand, string modelName, decimal price, string description)
        {

            Id = id;
            VehicleBrand = vehicleBrand;
            ModelName = modelName;
            Price = price;
            Description = description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.02M;

        }

        //alt format
        public VehicleModelDTO(VehicleModel vehicle)
        {

            Id = vehicle.Id;
            VehicleBrand = vehicle.VehicleBrand;
            ModelName = vehicle.ModelName;
            Price = vehicle.Price;
            Description = vehicle.Description;

            PriceString = string.Format("{0:C}", vehicle.Price);
            ShortDescription = vehicle.Description.Length <= 25 ? vehicle.Description : vehicle.Description.Substring(0, 25);
            Tax = vehicle.Price * 0.02M;

        }


    }

    

}
