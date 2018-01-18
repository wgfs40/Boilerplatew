using System.Threading.Tasks;
using Abp.Application.Services;
using fernandez.northwind.Configuration.Dto;

namespace fernandez.northwind.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}