using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuryaVineforceProject.Authorization.Country
{
    public class Country : Entity<int>
    {
        public string Name { get; set; }
    }
}
