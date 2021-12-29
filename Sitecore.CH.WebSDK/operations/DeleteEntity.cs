using System.Threading.Tasks;

namespace Sitecore.CH.WebSDK.operations
{
    static class DeleteEntity
    {
        // Delete Asset entity...
        public static Task DeleteAssetEntity()
        {
            long assetId = 31037;
            var myAsset = MConnector.Client.Entities.DeleteAsync(assetId);
            return myAsset;
        }
    }
}
