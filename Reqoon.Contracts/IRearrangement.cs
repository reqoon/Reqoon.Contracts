using System;
using System.Collections.Generic;

namespace Reqoon.Contracts
{
    public interface IRearrangement
    {
        Tuple<IRefinementLevel, List<IRequirementKey>> From { get; }
        Tuple<IRefinementLevel, List<IRequirementKey>> To { get; }
    }
}
