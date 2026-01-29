using System;
using System.Collections.Generic;
using System.Text;
using NobleDomain.Models;
namespace NobleDomain.Commands
{
    public interface ICreateSensor
    {
        Task<bool> ExecuteAsync(Sensor model);

    }
}
