using Takid.Api.Models;

namespace Takid.Api.Interfaces;

public interface ISupervisorInfoRepository
{
    public Task<IEnumerable<SupervisorInfo>> GetTopWorkingSupervisorsAsync(int companyId);
}