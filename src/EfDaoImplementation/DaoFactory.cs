using Contracts;

namespace EfDaoImplementation
{
    public class DaoFactory : IDaoFactory
    {
        #region IDaoFactory Members

        public IPersonDao GetPersonDao()
        {
            return new PersonDao();
        }

        public IDeveloperDao GetDeveloperDao()
        {
            return new DeveloperDao();
        }

        public IAnalystDao GetAnalystDao()
        {
            return new AnalystDao();
        }

        public IProjectDao GetProjectDao()
        {
            return new ProjectDao();
        }

        #endregion
    }
}
