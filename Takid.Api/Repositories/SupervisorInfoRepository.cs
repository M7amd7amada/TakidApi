using System.Data;
using Dapper;
using Takid.Api.Data;
using Takid.Api.Interfaces;
using Takid.Api.Models;

namespace Takid.Api.Repositories;

public class SupervisorInfoRepository : ISupervisorInfoRepository
{
    private readonly IDapperContext _context;

    public SupervisorInfoRepository(IDapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SupervisorInfo>> GetTopWorkingSupervisorsAsync(int companyId)
    {

        using IDbConnection connection = _context.CreateConnection();
        var top5WorkingSupervisors = await connection.QueryAsync<SupervisorInfo>(
            "Get_Top_5_Working_Supervisors",
            new { company_id = companyId },
            commandType: CommandType.StoredProcedure);

        return top5WorkingSupervisors;
    }
}