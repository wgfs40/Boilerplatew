using System.Collections.Generic;
using fernandez.northwind.Roles.Dto;
using fernandez.northwind.Users.Dto;

namespace fernandez.northwind.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}