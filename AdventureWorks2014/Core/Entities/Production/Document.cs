using System;
using AdventureWorks2014.Core.Entities.HumanResources;

namespace AdventureWorks2014.Core.Entities.Production
{
    public class Document
    {
        public string Nome { get; set; }
        public short Level { get; set; }
        public string Title { get; set; }
        public virtual Employee Owner { get; set; }
        public bool FolderFlag { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Revision { get; set; }
        public int ChangeNumber { get; set; }
        public byte Status { get; set; }
        public string Summary { get; set; }
        public byte[] File { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}