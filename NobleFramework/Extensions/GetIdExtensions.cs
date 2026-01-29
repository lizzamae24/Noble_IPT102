using System.Data;
using Dapper;

namespace NobleFramework.Extensions
{
    public static class GetIdExtensions
    {
        public static DynamicParameters GetSensorDynamicParameters(this int id, string parameterName)
        {
            var p = new DynamicParameters();
            p.Add($"@{parameterName}", id, DbType.Int32, ParameterDirection.Input);
            return p;
        }
    }
}
