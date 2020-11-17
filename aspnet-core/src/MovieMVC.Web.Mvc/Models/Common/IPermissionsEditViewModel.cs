using System.Collections.Generic;
using MovieMVC.Roles.Dto;

namespace MovieMVC.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}