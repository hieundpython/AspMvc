using System.Threading.Tasks;
using Abp.Application.Services;
using MovieMVC.Sessions.Dto;

namespace MovieMVC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
