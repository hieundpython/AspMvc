using System.Collections.Generic;
using MovieMVC.Roles.Dto;

namespace MovieMVC.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
