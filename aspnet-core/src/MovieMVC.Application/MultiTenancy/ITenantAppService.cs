using Abp.Application.Services;
using MovieMVC.MultiTenancy.Dto;

namespace MovieMVC.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

