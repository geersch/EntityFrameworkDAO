namespace Contracts
{
    public interface IDaoFactory
    {
        IPersonDao GetPersonDao();
        IDeveloperDao GetDeveloperDao();
        IAnalystDao GetAnalystDao();
        IProjectDao GetProjectDao();
    }
}
