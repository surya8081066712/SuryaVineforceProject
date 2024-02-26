using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SuryaVineforceProject.Country.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuryaVineforceProject.Country
{
    public interface ICountryAppService : IApplicationService
    {
        Task<CountryDto> Get(EntityDto<int> input);
        Task<ListResultDto<CountryDto>> GetAll();
        Task Create(CreateCountryDto input);
        Task Update(UpdateCountryDto input);
        Task Delete(int id);
    }
}
