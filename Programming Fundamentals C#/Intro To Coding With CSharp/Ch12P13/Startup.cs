using System;
using System.Net;

namespace Ch12P13
{
    public class Startup
    {
        public static void Main()
        {
            string url = Console.ReadLine();
            string fileName = "temp.jpg";

            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(url, fileName);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }
    }
}
