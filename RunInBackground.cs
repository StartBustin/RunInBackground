using MelonLoader;

namespace RunInBackground
{
    public static class BuildInfo
    {
        public const string Name = "Enable Run In Background"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Prevents the game from pausing when it loses focus."; // Description for the Mod.  (Set as null if none)
        public const string Author = "Catssandra Ann"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TestMod : MelonMod
    {
        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            UnityEngine.Application.runInBackground = true;
            MelonLogger.Msg("UnityEngine.Application.runInBackground = " + UnityEngine.Application.runInBackground.ToString());
        }
    }
}