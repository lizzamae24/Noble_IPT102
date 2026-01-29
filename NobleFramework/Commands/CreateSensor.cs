using NobleDomain.Commands;
using NobleDomain.Models;
using NobleFramework.Extensions;
using NobleRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobleFramework.Commands;

public class CreateSensor : ICreateSensor
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName;
    private readonly IRepository _repository;

    public CreateSensor(IRepository reposository)
    {
        _storedProcedureName = "[dbo].[CreateSensor]";
        _repository = reposository;
    }

    public async Task<bool> ExecuteAsync(Sensor model)
    {
        var p = model.ToSensorDynamicParameters();
        return await _repository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}
