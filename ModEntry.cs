
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

using Godot;


[ModInitializer(nameof(Initialize))]
public partial class ModEntry : Node
{
    public const string ModId = "NightOfTheWizard";
    public static MegaCrit.Sts2.Core.Logging.Logger Logger { get; } = new(ModId, MegaCrit.Sts2.Core.Logging.LogType.Generic);

    public static void Initialize()
    {
        Logger.Info("Night of the Wizard mod: Initialize called.");
        Harmony harmony = new(ModId);
        harmony.PatchAll();
        Logger.Info("Night of the Wizard mod: Initialize end.");
    }
}