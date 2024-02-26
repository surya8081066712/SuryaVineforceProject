using System.Collections.Generic;
using SuryaVineforceProject.Roles.Dto;

namespace SuryaVineforceProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
