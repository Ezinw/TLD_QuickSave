using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace QuickSave
{ 
    [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.Update))]
    internal class SaveLoad
    {
        private static readonly KeyCode saveKey = KeyCode.F5;
        private static readonly KeyCode loadKey = KeyCode.F6;

        static void Postfix(SaveGameSystem __instance)
        {
            if (GameManager.IsMainMenuActive() || 
                GameManager.m_IsPaused) 
            { 
                return; 
            }

            if (Input.GetKeyDown(saveKey))
            {
                GameManager.SaveGameAndDisplayHUDMessage();
            }

             if (Input.GetKeyDown(loadKey))
            {
                if (GameManager.GetExperienceModeManagerComponent().InCustomMode() ||
                    GameManager.GetExperienceModeManagerComponent().IsChallengeActive())
                {
                    SaveSlotInfo quickSaveSlot = SaveGameSystem.GetNewestSaveSlotForActiveGame();

                    if (quickSaveSlot != null)
                    {
                        GameManager.LoadSaveGameSlot(quickSaveSlot);
                    }
                }
                if (ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Pilgrim ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Voyageur ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Stalker ||
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


    //Disable GUI error sound
    [HarmonyPatch(typeof(GameAudioManager), "PlayGUIError")]
    class StopPlayGUIError
    {
        private static bool Prefix(GameAudioManager __instance)
        {
            if (Input.GetKeyDown(KeyCode.F5) || 
                Input.GetKeyDown(KeyCode.F6))
            {
                return false;
            }
            
            return true;
        }
    }

}
