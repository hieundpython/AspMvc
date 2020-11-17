using System.Collections.Generic;
using MovieMVC.Roles.Dto;

namespace MovieMVC.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
