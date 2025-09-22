using HarmonyLib;
using JellyfinLoader;

namespace JLExamplePlugin
{
    internal class EarlyLoader : IEarlyLoadPlugin
    {
        public void OnServerStart(bool coldStart)
        {
            Console.WriteLine($"Hello from {GetType().FullName} (coldStart = {coldStart})!");
            if (coldStart)
            {
                Console.WriteLine("Applying Harmony patches...");
                var harmony = new Harmony("com.github.stenlan.jellyfinloader-example-plugin");
                harmony.PatchAll();

                Console.WriteLine("Applied Harmony patches.");
            }
        }
    }
}
