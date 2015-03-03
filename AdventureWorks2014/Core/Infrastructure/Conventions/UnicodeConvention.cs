using System.Data.Entity.ModelConfiguration.Conventions;

namespace AdventureWorks2014.Core.Infrastructure.Conventions
{
    public class UnicodeConvention : Convention
    {
        public UnicodeConvention()
        {
            Properties<string>().Configure(t => t.IsUnicode(false));
        }
    }
}