using System.Threading.Tasks;
using Abp.Application.Services;
using sweet.log.Sessions.Dto;

namespace sweet.log.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
