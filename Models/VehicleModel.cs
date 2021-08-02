using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class VehicleModel
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
        [Required]
        [DisplayName("Description")]
        [StringLength(500)]
        public string Description { get; set; }

    }
}
