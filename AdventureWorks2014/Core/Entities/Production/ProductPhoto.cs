namespace AdventureWorks2014.Core.Entities.Production
{
    public class ProductPhoto : Entity<int>
    {
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbNailPhotoFileName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
    }
}