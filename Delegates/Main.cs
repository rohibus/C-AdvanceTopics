using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            var processor2 = new PhotoProcessor2();
            Action<Photo> filterHandler2 = filters.ApplyBrightness;
            filterHandler2 += filters.ApplyContrast;
            filterHandler2 += filters.Resize;

            processor2.Process("photo.jpg", filterHandler2);
        }

        public static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Apply RemoveRedEye");
        }
    }
}