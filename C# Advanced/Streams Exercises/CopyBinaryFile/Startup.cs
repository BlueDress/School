using System.IO;

namespace CopyBinaryFile
{
    public class Startup
    {
        public static void Main()
        {
            var fs = new FileStream("copyMe.png", FileMode.Open);
            var fsTocopy = new FileStream("result.png", FileMode.CreateNew);

            using (fs)
            {
                using (fsTocopy)
                {
                    fs.CopyTo(fsTocopy);
                }
            }
        }
    }
}
