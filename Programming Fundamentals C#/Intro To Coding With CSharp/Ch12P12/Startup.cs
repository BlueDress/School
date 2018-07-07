using System;
using System.IO;
using System.Security;

namespace Ch12P12
{
    public class Startup
    {
        public static void Main()
        {
            string filePath = Console.ReadLine();

            try
            {
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine(fileContents);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}
