using System.Data.Entity.ModelConfiguration.Conventions;
using AdventureWorks2014.Core.Entities;

namespace AdventureWorks2014.Core.Infrastructure.Conventions
{
    public class EntityConvention : Convention
    {
        public EntityConvention()
        {
            Types().Where(t => t.BaseType.GetGenericTypeDefinition() == typeof (Entity<>))
                .Configure(t =>
                {
                    t.Property("Id").HasColumnName(t.ClrType.Name + "ID");
                    t.Property("ModifiedDate").IsRequired();
                });
        }
    }
}