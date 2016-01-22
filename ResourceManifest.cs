using Orchard.UI.Resources;

namespace Lombiq.Hosting.Deployments
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineStyle("Lombiq.Hosting.Deployments.BuildNumber.Admin").SetUrl("hosting-deployments-buildnumber-admin.css");
        }
    }
}