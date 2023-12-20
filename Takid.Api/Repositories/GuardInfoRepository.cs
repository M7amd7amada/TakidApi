using System.Data;
using Dapper;
using Takid.Api.Data;
using Takid.Api.Interfaces;
using Takid.Api.Models;

namespace Takid.Api.Repositories;

public class GuardInfoRepository : IGuardInfoRepository
{
    private readonly IDapperContext _context;

    public GuardInfoRepository(IDapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<GuardInfo>> GetTopWorkingGuardsAsync(int companyId)
    {
        using IDbConnection connection = _context.CreateConnection();
        var top5WorkingGuards = await connection.QueryAsync<GuardInfo>(
            "Get_Top_5_Working_Employees",
            new { company_id = companyId },
            commandType: CommandType.StoredProcedure);

        return top5WorkingGuards;
    }
}