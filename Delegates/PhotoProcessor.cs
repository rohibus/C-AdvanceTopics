namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }

        // We can not modify in this approach
        // public void Process(string path)
        // {
        //     var photo = new Photo(path);
        //     var filters = new PhotoFilters();
        //     filters.ApplyBrightness(photo);
        //     filters.ApplyContrast(photo);
        //     filters.Resize(photo);

        //     photo.Save();
        // }
    }
}