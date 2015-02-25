using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using AdventureWorks2014.Core.Entities;

namespace AdventureWorks2014.Core.Infrastructure.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DataContext()
        {
            Database.SetInitializer<DataContext>(null);

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            //Ligar o lazy loading e o proxy nos momentos em que precisar
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var assemblyTypes = typeof(DataContext).Assembly.GetTypes();

            var configurationTypes = assemblyTypes.Where(t => t.IsAbstract == false &&
                                                              t.BaseType != null &&
                                                              t.BaseType.IsGenericType &&
                                                              (t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>) ||
                                                              t.BaseType.GetGenericTypeDefinition() == typeof(ComplexTypeConfiguration<>)))
                                                  .ToArray();

            foreach (var configurationType in configurationTypes)
            {
                dynamic configurationTypeInstance = Activator.CreateInstance(configurationType);
                modelBuilder.Configurations.Add(configurationTypeInstance);
            }

            var conventionTypes = assemblyTypes.Where(t => t.IsAbstract == false &&
                                                           t.BaseType != null &&
                                                           t.BaseType == typeof(Convention))
                                               .ToArray();

            foreach(var conventionType in conventionTypes)
            {
                dynamic conventionTypeInstance = Activator.CreateInstance(conventionType);
                modelBuilder.Conventions.Add(conventionTypeInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}