using Domain;

namespace EfDaoImplementation
{
    public class ObjectContextManager
    {
        private static readonly ProjectsEntities context = new ProjectsEntities();
        private ObjectContextManager() { }
        public static ProjectsEntities Context { get { return context; } }
    }
}
