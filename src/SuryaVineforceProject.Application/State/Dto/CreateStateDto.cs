using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuryaVineforceProject.State.Dto
{
    public class CreateStateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
