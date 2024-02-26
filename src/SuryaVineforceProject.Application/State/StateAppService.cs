using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using SuryaVineforceProject.Authorization;
using SuryaVineforceProject.State.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuryaVineforceProject.State
{
    public class StateAppService : ApplicationService, IStateAppService
    {
        private readonly IRepository<Authorization.State.State, int> _stateRepository;

        public StateAppService(IRepository<Authorization.State.State, int> stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task<StateDto> Get(EntityDto<int> input)
        {
            var state = await _stateRepository.GetAsync(input.Id);
            return ObjectMapper.Map<StateDto>(state);
        }

        public async Task<ListResultDto<StateDto>> GetAll()
        {
            var states = await _stateRepository.GetAllListAsync();
            return new ListResultDto<StateDto>(ObjectMapper.Map<List<StateDto>>(states));
        }

        public async Task Create(CreateStateDto input)
        {
            var state = ObjectMapper.Map<Authorization.State.State>(input);
            await _stateRepository.InsertAsync(state);
        }

        public async Task Update(UpdateStateDto input)
        {
            var state = await _stateRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, state);
        }

        public async Task Delete(int id)
        {
            await _stateRepository.DeleteAsync(id);
        }           
    }
}
