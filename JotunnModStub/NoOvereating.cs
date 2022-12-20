// NoOvereating
// a Valheim mod that adds versions of foods that last 2 hours each instead of however long they normally last. The new foods/recipes are otherwise identical to the original.
// 
// File:    NoOvereating.cs
// Project: NoOvereating

using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;

namespace NoOvereating
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class NoOvereating : BaseUnityPlugin
    {
        public const string PluginGUID = "com.spacetornado.noovereating";
        public const string PluginName = "NoOvereating";
        public const string PluginVersion = "0.0.1";
        
        // Use this class to add your own localization to the game
        // https://valheim-modding.github.io/Jotunn/tutorials/localization.html
        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("NoOvereating mod loaded.");
            
        }
    }
}