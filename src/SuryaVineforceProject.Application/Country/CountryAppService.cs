using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using SuryaVineforceProject.Authorization;
using System.Text;
using System.Threading.Tasks;
using SuryaVineforceProject.Country.Dto;

namespace SuryaVineforceProject.Country
{
    public class CountryAppService : ApplicationService, ICountryAppService
    {
        private readonly IRepository<Authorization.Country.Country, int> _countryRepository;

        public CountryAppService(IRepository<Authorization.Country.Country, int> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<ListResultDto<CountryDto>> GetAll()
        {
            var countries = await _countryRepository.GetAllListAsync();
            return new ListResultDto<CountryDto>(ObjectMapper.Map<List<CountryDto>>(countries));
        }

        public async Task<CountryDto> Get(EntityDto<int> input)
        {
            var country = await _countryRepository.GetAsync(input.Id);
            return ObjectMapper.Map<CountryDto>(country);
        }

        public async Task Create(CreateCountryDto input)
        {
            var country = ObjectMapper.Map<Authorization.Country.Country>(input);
            await _countryRepository.InsertAsync(country);
        }

        public async Task Update(UpdateCountryDto input)
        {
            var country = await _countryRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, country);
        }

        public async Task Delete(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }
    }
}