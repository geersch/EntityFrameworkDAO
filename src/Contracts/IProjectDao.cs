using System.Collections.Generic;
using Domain;

namespace Contracts
{
    public interface IProjectDao : IDao<Project>
    {
        IEnumerable<Project> GetProjectsOfPerson(Person person);
    }
}
