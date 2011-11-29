using System.Collections.Generic;

namespace Reqoon.Contracts.Tests
{
    public interface ITraceableTestCase
    {
        List<IRequirementKey> RequirementKeysToBeTested { get; }
    }
}
