using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using Microsoft.Extensions.Logging;

namespace JLExamplePlugin
{
    public class JLExamplePlugin : BasePlugin<JLExamplePluginConfig>
    {
        public JLExamplePlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer, ILogger<JLExamplePlugin> logger) : base(applicationPaths, xmlSerializer)
        {
            logger.LogInformation("Hello from {myName}!", nameof(JLExamplePlugin));
        }

        public override string Name => "JellyfinLoader Example Plugin";
        public override Guid Id => Guid.Parse("abd1fca1-2c37-4cf3-9bbe-d91315004473");
    }
}
