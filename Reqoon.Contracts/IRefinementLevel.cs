using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Reqoon.Contracts
{
    public interface IRefinementLevel
    {
        Task<List<IRefinementLevelElement>> GetRefinementLevelElements(CancellationToken cancellationToken);
    }
}
