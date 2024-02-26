using System.Collections.Generic;
using SuryaVineforceProject.Roles.Dto;

namespace SuryaVineforceProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
