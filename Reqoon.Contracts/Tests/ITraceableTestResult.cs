namespace Reqoon.Contracts.Tests
{
    public interface ITraceableTestResult
    {
        IRequirementKey TestedRequirementKey { get; }

        TestResult TestResult { get; }
    }
}