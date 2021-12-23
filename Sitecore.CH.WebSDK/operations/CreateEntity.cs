using Stylelabs.M.Framework.Essentials.LoadOptions;
using Stylelabs.M.Sdk.Contracts.Base;
using Stylelabs.M.Sdk.Models.Jobs;
using System;
using System.Threading.Tasks;

namespace Sitecore.CH.WebSDK.operations
{
    static class CreateEntity
    {
        // Create Asset entity...
        public static async Task<long> CreateAssetEntity()
        {
            IEntity assetEntity= await MConnector.Client.EntityFactory.CreateAsync("M.Asset", CultureLoadOption.Default).ConfigureAwait(false);
            assetEntity.SetPropertyValue("Title", "Sample Asset From SDK Test");

            long assetId= await MConnector.Client.Entities.SaveAsync(assetEntity).ConfigureAwait(false);

            // Create fetch job to link asset to entity...
            var webFetchJob = new WebFetchJobRequest("SampleAssetFile", assetId)
            {
                Urls = new[] { new Uri("https://cdn.pixabay.com/photo/2021/12/10/13/59/star-6860582_960_720.jpg") }
            };

            long jobId = await MConnector.Client.Jobs.CreateFetchJobAsync(webFetchJob);
            return assetId;
        }
    }
}
