using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuryaVineforceProject.Country.Dto
{
    
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
