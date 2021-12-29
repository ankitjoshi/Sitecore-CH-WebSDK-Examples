using Sitecore.CH.WebSDK.operations;
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
                // await MConnector.Client.TestConnectionAsync();
                // Console.WriteLine("Connection Succesful!!");

                // Create entity of M.Asset type
                // var assetId = await CreateEntity.CreateAssetEntity();

                // Delete entity of M.Asset type
                // await DeleteEntity.DeleteAssetEntity();

                // Update entity of M.Asset type
                await UpdateEntity.UpdateAssetEntity();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
