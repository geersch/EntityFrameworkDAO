using System.Collections.Generic;
using Contracts;
using Domain;

namespace Managers
{
    public class PersonManager
    {
        private readonly IDaoFactory daoFactory;

        public PersonManager(IDaoFactory daoFactory)
        {
            this.daoFactory = daoFactory;
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            IDeveloperDao dao = daoFactory.GetDeveloperDao();
            return dao.GetDevelopers();
        }

        public IEnumerable<Analyst> GetAnalysts()
        {
            IAnalystDao dao = daoFactory.GetAnalystDao();
            return dao.GetAnalysts();
        }

        public IEnumerable<Project> GetProjectsOfPerson(Person person)
        {
            IProjectDao dao = daoFactory.GetProjectDao();
            return dao.GetProjectsOfPerson(person);
        }
    }
}
