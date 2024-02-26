﻿using System.Threading.Tasks;
using Abp.Application.Services;
using SuryaVineforceProject.Authorization.Accounts.Dto;

namespace SuryaVineforceProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
