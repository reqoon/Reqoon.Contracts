using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Reqoon.Contracts
{
    public interface IProject
    {
        Task<List<IRefinementLevel>> GetRefinementLevels(CancellationToken cancellationToken);

    }
}
