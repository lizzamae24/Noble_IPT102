using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NobleDomain.Models;
using NobleFramework.Extensions;
using NobleRepository.Interfaces;

namespace IPT102Framework.Queries;

public class GetSensorById
{
    private readonly string _connectionName;
    private readonly string _storedProcedureName;
    private readonly IRepository _repository;

    public GetSensorById(IRepository reposository)
    {
        _connectionName = "DefaultConnection";
        _storedProcedureName = "[dbo].[GetSensorById]";
        _repository = reposository;
    }



    public async Task<Sensor?> ExecuteAsync(int id)
    {
        var parameters = id.GetSensorDynamicParameters("Id");
        var result = await _repository.GetDataAsync<Sensor>(_connectionName, _storedProcedureName, parameters);

        return result.FirstOrDefault();
    }
}

