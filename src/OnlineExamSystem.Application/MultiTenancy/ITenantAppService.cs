using Abp.Application.Services;
using OnlineExamSystem.MultiTenancy.Dto;

namespace OnlineExamSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

