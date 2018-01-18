using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fernandez.northwind.Roles.Dto;
using fernandez.northwind.Users.Dto;

namespace fernandez.northwind.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}