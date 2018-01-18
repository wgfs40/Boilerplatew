using System.Threading.Tasks;
using Abp.Application.Services;
using fernandez.northwind.Sessions.Dto;

namespace fernandez.northwind.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
