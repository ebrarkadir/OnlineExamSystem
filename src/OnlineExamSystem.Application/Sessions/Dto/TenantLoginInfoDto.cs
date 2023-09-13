using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OnlineExamSystem.MultiTenancy;

namespace OnlineExamSystem.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
