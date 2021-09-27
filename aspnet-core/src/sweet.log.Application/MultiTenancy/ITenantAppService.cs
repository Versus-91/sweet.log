using Abp.Application.Services;
using sweet.log.MultiTenancy.Dto;

namespace sweet.log.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

