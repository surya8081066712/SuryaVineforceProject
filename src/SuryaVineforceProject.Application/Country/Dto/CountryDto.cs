using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuryaVineforceProject.Country.Dto
{
    public class CountryDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
