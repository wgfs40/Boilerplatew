using Abp.AutoMapper;
using fernandez.northwind.Sessions.Dto;

namespace fernandez.northwind.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}