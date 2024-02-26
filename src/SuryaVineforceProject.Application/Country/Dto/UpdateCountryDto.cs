using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuryaVineforceProject.Country.Dto
{
    public class UpdateCountryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
