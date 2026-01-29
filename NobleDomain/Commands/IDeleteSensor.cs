using System;
using System.Collections.Generic;
using System.Text;
using NobleDomain.Models;

namespace NobleDomain.Commands
{
    public interface IDeleteSensor
    {
        Task<bool> ExecuteAsync(Sensor model);

    }
}
