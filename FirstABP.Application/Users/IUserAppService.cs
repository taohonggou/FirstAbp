using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FirstABP.Users.Dto;

namespace FirstABP.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}