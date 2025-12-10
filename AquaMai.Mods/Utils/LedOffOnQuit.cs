using System.Threading;
using AquaMai.Config.Attributes;
using HarmonyLib;
using IO;
using Main;

namespace AquaMai.Mods.Utils;

[ConfigSection("退出时关闭灯光")]
public class LedOffOnQuit
{
    [HarmonyPatch(typeof(GameMain), nameof(GameMain.OnApplicationQuit))]
    [HarmonyPrefix]
    private static void OnApplicationQuit_Prefix()
    {
        MechaManager.SetAllCuOff();
        MechaManager.Execute();
        Thread.Sleep(100);
    }
}