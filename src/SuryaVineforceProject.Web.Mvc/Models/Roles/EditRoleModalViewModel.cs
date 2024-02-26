using Abp.AutoMapper;
using SuryaVineforceProject.Roles.Dto;
using SuryaVineforceProject.Web.Models.Common;

namespace SuryaVineforceProject.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
