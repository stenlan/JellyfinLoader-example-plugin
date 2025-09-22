using HarmonyLib;
using Microsoft.Extensions.Logging;

namespace JLExamplePlugin
{
    [HarmonyPatch(typeof(LoggerExtensions), "LogInformation", [typeof(ILogger), typeof(string), typeof(object?[])])]
    internal class LoggerPatch
    {
        public static void Prefix(object?[] args)
        {
            if (args == null) return;

            for (int i = 0; i < args.Length; i++)
            {
                args[i] = "PATCHED";
            }
        }
    }
}
