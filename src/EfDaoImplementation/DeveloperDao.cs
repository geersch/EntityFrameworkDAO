using System.Collections.Generic;
using Contracts;
using Domain;

namespace EfDaoImplementation
{
    public class DeveloperDao : PersonDao, IDeveloperDao
    {
        #region IDeveloperDao Members

        public IEnumerable<Developer> GetDevelopers()
        {
            return Context.People.OfType<Developer>();
        }

        #endregion
    }
}
