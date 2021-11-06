using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Linq;

namespace EfDaoImplementation
{
    public static class ObjectContextExtensions
    {
        public static string GetEntitySetName(this ObjectContext context, string entityTypeName)
        {
            var container = context.MetadataWorkspace.GetEntityContainer(context.DefaultContainerName, DataSpace.CSpace);
            string entitySetName = (from meta in container.BaseEntitySets
                                    where meta.ElementType.Name == entityTypeName
                                    select meta.Name).FirstOrDefault();
            return entitySetName;
        }
    }
}
