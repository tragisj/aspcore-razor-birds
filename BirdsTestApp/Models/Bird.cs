using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsTestApp.Models
{
    public class Bird
    {   
        [DisplayName("Common Name:")]
        [Required(ErrorMessage = "Please enter the bird's common name")]
        public string CommonName { get; set; }

        [DisplayName("Scientific Name:")]
        [Required(ErrorMessage = "Please enter the bird's scientific name")]
        public string ScientificName { get; set; }

        [DisplayName("Wing Span:")]
        [Required(ErrorMessage = "Please enter the bird's wingspan")]
        public int WingSpan { get; set; }

        public string ColorMarking { get; set; }

        [DisplayName("Range and Distribution:")]
        [Required(ErrorMessage = "Please enter the bird's range / distribution")]
        public string Distribution { get; set; }

        [DisplayName("ID Number:")]
        [Required(ErrorMessage = "Please enter the bird's ID number")]
        public int ID { get; set; }
    }
}
