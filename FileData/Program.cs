using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                if (args != null && args?.Count() == 2)
                {
                    List<string> versionShortcuts = new List<string>() { "-v", "--v", "/ v", "--version" };
                    List<string> sizeShortcuts = new List<string>() { "-s", "--s", "/ s", "--size" };
                    FileDetails objFileDetails = new FileDetails();

                    if (versionShortcuts.Contains(args[0]))
                    {
                        Console.Write("Version details : " + objFileDetails.Version(args[1]));
                    }
                    else if (sizeShortcuts.Contains(args[0]))
                    {
                        Console.Write("Size details : " + objFileDetails.Size(args[1]));
                    }
                    else
                    {
                        Console.Write("Passed invalid arguments");
                    }

                }
                else
                {
                    Console.Write("Passed invalid number of arguments");
                }
            }
            catch (Exception ex)
            { 
                Console.Write("Exception occuered : " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
