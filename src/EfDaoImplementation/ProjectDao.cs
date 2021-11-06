using System.Collections.Generic;
using System.Linq;
using Contracts;
using Domain;

namespace EfDaoImplementation
{
    public class ProjectDao : EntityDao<Project>, IProjectDao
    {
        #region IProjectDao Members

        public IEnumerable<Project> GetProjectsOfPerson(Person person)
        {
            return from project in Context.Projects 
                   where project.People.Any(p => p.Id == person.Id) 
                   select project;
        }

        #endregion
    }
}
