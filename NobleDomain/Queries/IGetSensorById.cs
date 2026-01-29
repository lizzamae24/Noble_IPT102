using System;
using System.Collections.Generic;
using System.Text;
using NobleDomain.Models;
namespace NobleDomain.Queries
{
    public interface IGetSensorById
    {
        Task<Sensor?> ExecuteAsync(int id);

    }
}
