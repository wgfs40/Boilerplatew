using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fernandez.northwind.Roles.Dto;

namespace fernandez.northwind.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
