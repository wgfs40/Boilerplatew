using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using fernandez.northwind.MultiTenancy;

namespace fernandez.northwind.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}