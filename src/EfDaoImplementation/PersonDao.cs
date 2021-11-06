using Contracts;
using Domain;

namespace EfDaoImplementation
{
    public class PersonDao : EntityDao<Person>, IPersonDao
    { }
}
