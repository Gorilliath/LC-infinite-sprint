﻿using BepInEx;
using Gorilliath.InfiniteSprint.Patches;
using HarmonyLib;

namespace Gorilliath.InfiniteSprint
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private readonly Harmony harmony = new(PluginInfo.PLUGIN_GUID);
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            harmony.PatchAll(typeof(Plugin));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
