using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [Range(1990, 2023)]
        public int Year { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Model is too long")]
        public string Model { get; set; }


        public int? MakeId { get; set; }
        public virtual Make Make { get; set; }
    }
}
