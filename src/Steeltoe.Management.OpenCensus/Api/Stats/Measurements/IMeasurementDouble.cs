﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Steeltoe.Management.Census.Stats.Measurements
{
    public interface IMeasurementDouble : IMeasurement
    {
        double Value { get; }
    }
}
