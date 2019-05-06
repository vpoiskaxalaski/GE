namespace GE.DAL.Model
{
    public class ImagesGallery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        //public byte[] ImageData { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
