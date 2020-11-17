using System.Threading.Tasks;
using Abp.Application.Services;
using MovieMVC.Authorization.Accounts.Dto;

namespace MovieMVC.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
