using Abp.Application.Services.Dto;
using SuryaVineforceProject.Country.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuryaVineforceProject.State.Dto
{
    public class StateDto : EntityDto<int>
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public CountryDto Country { get; set; }
    }
}

