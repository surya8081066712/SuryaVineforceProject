using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SuryaVineforceProject.State.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuryaVineforceProject.State
{
    public interface IStateAppService : IApplicationService
    {
        Task<StateDto> Get(EntityDto<int> input);
        Task<ListResultDto<StateDto>> GetAll();
        Task Create(CreateStateDto input);
        Task Update(UpdateStateDto input);
        Task Delete(int id);
    }
}
