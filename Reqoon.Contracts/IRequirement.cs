namespace Reqoon.Contracts
{
    public interface IRequirement : ITraceableElement
    {
    }

    public interface ITraceableElement
    {
        IRequirementKey RequirementKey { get; }
    }
}
