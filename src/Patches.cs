using HarmonyLib;
using Il2Cpp;
using Il2CppParadoxNotion.Services;
using Il2CppTLD.Gameplay;
using UnityEngine;

namespace QuickSave
{

    //Quicksaving...
    [HarmonyPatch(typeof(GameManager), "Update")]
    internal class QuickSave
    {
        private static readonly KeyCode saveKey = KeyCode.F5;

        static void Postfix(GameManager __instance)
        {
            if (Input.GetKeyDown(saveKey))
            {
                GameManager.SaveGameAndDisplayHUDMessage();
            }
        }
    }

    //Quickloading...
    [HarmonyPatch(typeof(GameManager), "Update")]
    internal class QuickLoad
    {
        private static readonly KeyCode loadKey = KeyCode.F6;

        static void Postfix(GameManager __instance)
        {
            if (Input.GetKeyDown(loadKey))
            {
                if (GameManager.IsMainMenuActive())
                    return;

                if (GameManager.GetExperienceModeManagerComponent().InCustomMode()||
                    GameManager.GetExperienceModeManagerComponent().IsChallengeActive())
                {
                    SaveSlotInfo quickSaveSlot = SaveGameSystem.GetNewestSaveSlotForActiveGame();

                    if (quickSaveSlot != null)
                    {
                        GameManager.LoadSaveGameSlot(quickSaveSlot);
                    }
                }
                if (ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Pilgrim    ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Voyageur   ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Stalker    ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Interloper)
                {
                    SaveSlotInfo quickSaveSlot = SaveGameSystem.GetNewestSaveSlotForActiveGame();

                    if (quickSaveSlot != null)
                    {
                        GameManager.LoadSaveGameSlot(quickSaveSlot);
                    }
            
                }
                
            }
        
        }

    }

    
    [HarmonyPatch(typeof(GameAudioManager), "PlayGUIError")]
    class GameAudioManager_PlayGUIError_Patch
    {
        static bool Prefix(GameAudioManager __instance)
        {
            if (Input.GetKeyDown(KeyCode.F5) ||
                Input.GetKeyDown(KeyCode.F6))
            {
                AudioSource audioSource = __instance.gameObject.GetComponent<AudioSource>();

                if (audioSource.clip != null && audioSource.clip.name == "PlayGUIError")
                {
                    audioSource.Stop();

                    return false;
                }
            }
            
            return true;
        }
    }
}
