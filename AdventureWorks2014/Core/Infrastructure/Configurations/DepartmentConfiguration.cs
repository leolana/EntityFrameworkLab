using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks2014.Core.Entities;

namespace AdventureWorks2014.Core.Infrastructure.Configurations
{
    //Esta classe representa toda a abstração com o acesso à dados da aplicação
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            ToTable("Department", "HumanResources");
            Property(d => d.Id).HasColumnName("DepartmentID")
                               .HasDatabaseGeneratedOption(databaseGeneratedOption: DatabaseGeneratedOption.Identity);
            Property(d => d.Name).HasColumnName("Name")
                                 .HasMaxLength(50)
                                 .IsUnicode(false);
            Property(d => d.GroupName).IsUnicode(false)
                                     .HasMaxLength(50);
            Property(d => d.ModifiedDate).HasColumnName("ModifiedDate")
                                         .HasColumnType("datetime");
        }
    }
}