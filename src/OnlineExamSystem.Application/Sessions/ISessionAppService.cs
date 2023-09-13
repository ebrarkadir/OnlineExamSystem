using System.Threading.Tasks;
using Abp.Application.Services;
using OnlineExamSystem.Sessions.Dto;

namespace OnlineExamSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
