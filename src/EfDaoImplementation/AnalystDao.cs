using System.Collections.Generic;
using Contracts;
using Domain;

namespace EfDaoImplementation
{
    public class AnalystDao : PersonDao, IAnalystDao
    {
        #region IAnalystDao Members

        public IEnumerable<Analyst> GetAnalysts()
        {
            return Context.People.OfType<Analyst>();
        }

        #endregion
    }
}
