using System.Collections.Generic;
using SuryaVineforceProject.Roles.Dto;

namespace SuryaVineforceProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}