using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore50Adventure.Model
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First name cannot exceed 100 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "State abbreviation cannot exceed 3 characters.")]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$",
            ErrorMessage = "Enter a valid zipcode in 55555 or 55555-5555 format")]
        public string ZipCode { get; set; }

        public string City { get; set; }
    }
}
