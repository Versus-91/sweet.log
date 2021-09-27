using System.Threading.Tasks;
using Abp.Application.Services;
using sweet.log.Authorization.Accounts.Dto;

namespace sweet.log.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
