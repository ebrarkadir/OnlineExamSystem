using System.Threading.Tasks;
using Abp.Application.Services;
using OnlineExamSystem.Authorization.Accounts.Dto;

namespace OnlineExamSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
