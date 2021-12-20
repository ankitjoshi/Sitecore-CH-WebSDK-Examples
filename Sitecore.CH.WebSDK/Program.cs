using System;
using System.Threading.Tasks;

namespace Sitecore.CH.WebSDK
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // Check if the connection is successful!!
                await MConnector.Client.TestConnectionAsync();
                Console.WriteLine("Connection Succesful!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
