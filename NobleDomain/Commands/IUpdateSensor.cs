using System;
using System.Collections.Generic;
using System.Text;
using NobleDomain.Models;

namespace NobleDomain.Commands
{
    public interface IUpdateSensor
    {
        Task<bool> ExecuteAsync(Sensor model);

    }
}
