using System.Collections.Generic;
using Domain;

namespace Contracts
{
    public interface IAnalystDao : IPersonDao
    {
        IEnumerable<Analyst> GetAnalysts();
    }
}
