using System.Data;
using Dapper;
using NobleDomain.Models;

namespace NobleFramework.Extensions;

public static class SensorExtension
{
    public static DynamicParameters ToSensorDynamicParameters(this Sensor model)
    {
        var p = new DynamicParameters();

        p.Add("@SensorId", model.SensorId, DbType.Int32, ParameterDirection.Input);
        p.Add("@SensorName", model.SensorName, DbType.String, ParameterDirection.Input);
        p.Add("@SensorType", model.SensorType, DbType.String, ParameterDirection.Input);
        p.Add("@Location", model.Location, DbType.String, ParameterDirection.Input);
        p.Add("@LastReading", model.LastReading, DbType.Decimal, ParameterDirection.Input);

        return p;
    }
}
