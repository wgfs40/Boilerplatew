using System.Data.Entity;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using fernandez.northwind.Users;
using fernandez.northwind.Users.Dto;
using Shouldly;
using Xunit;

namespace fernandez.northwind.Tests.Users
{
    public class UserAppService_Tests : northwindTestBase
    {
        private readonly IUserAppService _userAppService;

        public UserAppService_Tests()
        {
            _userAppService = Resolve<IUserAppService>();
        }

        [Fact]
        public async Task GetUsers_Test()
        {
            //Act
            var output = await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = 20, SkipCount = 0 });

            //Assert
            output.Items.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task CreateUser_Test()
        {
            //Act
            await _userAppService.Create(
                new CreateUserDto
                {
                    EmailAddress = "john@volosoft.com",
                    IsActive = true,
                    Name = "John",
                    Surname = "Nash",
                    Password = "123qwe",
                    UserName = "john.nash",
                    RoleNames = new string[0]
                });

            await UsingDbContextAsync(async context =>
            {
                var johnNashUser = await context.Users.FirstOrDefaultAsync(u => u.UserName == "john.nash");
                johnNashUser.ShouldNotBeNull();
            });
        }
    }
}
