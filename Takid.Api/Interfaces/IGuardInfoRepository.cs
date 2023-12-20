using Takid.Api.Models;

namespace Takid.Api.Interfaces;

public interface IGuardInfoRepository
{
    public Task<IEnumerable<GuardInfo>> GetTopWorkingGuardsAsync(int companyId);
}