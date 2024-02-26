using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using SuryaVineforceProject.Authorization.Country;
using System.Text;

namespace SuryaVineforceProject.Authorization.State
{
    public class State : Entity<int>
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country.Country  Country {get; set; }
    }
}
