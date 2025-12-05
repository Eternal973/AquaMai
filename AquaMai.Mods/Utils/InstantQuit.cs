using System;
using AquaMai.Config.Attributes;
using AquaMai.Config.Types;
using AquaMai.Core.Helpers;
using HarmonyLib;
using Main;
using UnityEngine;

namespace AquaMai.Mods.Utils;

[ConfigSection(
    name: "瞬间退出",
    en: "Quit the game instantly.",
    zh: "让你的游戏更快的退出（按 ESC 或使用系统测试模式时），立即结束进程的那种，不会卡一会儿")]
public class InstantQuit
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Application), "Quit", [])]
    public static bool OnGameMainObjectUpdate()
    {
        MelonLoader.MelonLogger.Msg("[InstantQuit] Quitting game...");
        System.Diagnostics.Process.GetCurrentProcess().Kill();
        return false;
    }
}
