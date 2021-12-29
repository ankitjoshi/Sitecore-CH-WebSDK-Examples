using Stylelabs.M.Sdk.Contracts.Base;
using System.Threading.Tasks;

namespace Sitecore.CH.WebSDK.operations
{
    static class UpdateEntity
    {
        // Update Asset entity...
        public static async Task UpdateAssetEntity()
        {
            long assetId = 31342;
            IEntity assetEntity = await MConnector.Client.Entities.GetAsync(assetId);

            assetEntity.SetPropertyValue("AssetDescription", "Asset Description from SDK");


            // Update Relation (Asset Type)
            IEntity assetTypeEntity= await MConnector.Client.Entities.GetAsync("M.AssetType.TestAssetType");
            IChildToOneParentRelation assetEntityRelation = await assetEntity.GetRelationAsync<IChildToOneParentRelation>("AssetTypeToAsset");

            assetEntityRelation.Parent = assetTypeEntity.Id.Value;

            await MConnector.Client.Entities.SaveAsync(assetEntity);
        }
    }
}
