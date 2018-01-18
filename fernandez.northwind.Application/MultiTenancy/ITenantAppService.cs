using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fernandez.northwind.MultiTenancy.Dto;

namespace fernandez.northwind.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
