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
                GameManager.m_IsPaused ||
                SaveGameSystem.IsAsyncSaveRunning())
            {
                return;
            }

            if (Input.GetKeyDown(saveKey))
            {
                // Check if saving is allowed and not already saving
                if (!SaveGameSystem.IsAsyncEnabled() || 
                    SaveGameSystem.IsAsyncSaveRunning())
                {
                    return;
                }

                //Prevent saving while inventory / other panels are open
                if (PanelCheck.IsPanelOpen())
                {
                    return;
                }

                //Save game
                GameManager.SaveGameAndDisplayHUDMessage();
            }

            if (Input.GetKeyDown(loadKey))
            {
                // Prevent loading if saving is in progress
                if (SaveGameSystem.IsAsyncSaveRunning())
                {
                    return;
                }

                if (GameManager.GetExperienceModeManagerComponent().InCustomMode() ||
                    GameManager.GetExperienceModeManagerComponent().IsChallengeActive() ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Pilgrim ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Voyageur ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Stalker ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Interloper ||
                    ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Misery)
                {
                    SaveSlotInfo quickSaveSlot = SaveGameSystem.GetNewestSaveSlotForActiveGame();

                    if (quickSaveSlot != null)
                    {
                        //Prevent loading while inventory / other panels are open
                        if (PanelCheck.IsPanelOpen())
                        {
                            return;
                        }

                        //Load saved game from quicksaveslot
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
