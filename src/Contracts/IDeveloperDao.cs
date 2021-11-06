using System.Collections.Generic;
using Domain;

namespace Contracts
{
    public interface IDeveloperDao : IPersonDao
    {
        IEnumerable<Developer> GetDevelopers();
    }
}
