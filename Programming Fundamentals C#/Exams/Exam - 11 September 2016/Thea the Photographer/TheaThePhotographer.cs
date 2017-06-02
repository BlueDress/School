using System;

namespace Thea_the_Photographer
{
    public class TheaThePhotographer
    {
        public static void Main(string[] args)
        {
            var numberOfPictures = double.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var filterFactorOnePic = double.Parse(Console.ReadLine());
            var uploadingTimeOnePic = double.Parse(Console.ReadLine());

            var filterTimeAll = numberOfPictures * filterTime;
            var goodPics = Math.Ceiling(filterFactorOnePic / 100 * numberOfPictures);
            var uploadingTimaAll = goodPics * uploadingTimeOnePic;
            var timeNeededSecs = filterTimeAll + uploadingTimaAll;

            TimeSpan timeNeeded = TimeSpan.FromSeconds(timeNeededSecs);
            Console.WriteLine(timeNeeded.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
