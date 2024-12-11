using Il2Cpp;
using Il2CppInterop.Runtime;

namespace QuickSave
{
    public static class PanelCheck
    {
        private static readonly List<Il2CppSystem.Type> panelTypes = new()
          {
               Il2CppType.Of<Panel_ActionPicker>(),
               Il2CppType.Of<Panel_Actions>(),
               Il2CppType.Of<Panel_ActionsRadial>(),
               Il2CppType.Of<Panel_Affliction>(),
               Il2CppType.Of<Panel_Badges>(),
               Il2CppType.Of<Panel_Base>(),
               Il2CppType.Of<Panel_BedRollSelect>(),
               Il2CppType.Of<Panel_BodyHarvest>(),
               Il2CppType.Of<Panel_BodyHarvest_MenuItem>(),
               Il2CppType.Of<Panel_BreakDown>(),
               Il2CppType.Of<Panel_Camera>(),
               Il2CppType.Of<Panel_CanOpening>(),
               Il2CppType.Of<Panel_Clothing>(),
               Il2CppType.Of<Panel_Confirmation>(),
               Il2CppType.Of<Panel_Container>(),
               Il2CppType.Of<Panel_Cooking>(),
               Il2CppType.Of<Panel_CookWater>(),
               Il2CppType.Of<Panel_Crafting>(),
               Il2CppType.Of<Panel_Credits>(),
               Il2CppType.Of<Panel_CuringStorage>(),
               Il2CppType.Of<Panel_Diagnosis>(),
               Il2CppType.Of<Panel_ExchangeBox>(),
               Il2CppType.Of<Panel_Extras>(),
               Il2CppType.Of<Panel_FeedFire>(),
               Il2CppType.Of<Panel_FireStart>(),
               Il2CppType.Of<Panel_FirstAid>(),
               Il2CppType.Of<Panel_GearSelect>(),
               Il2CppType.Of<Panel_Harvest>(),
               Il2CppType.Of<Panel_Help>(),
               Il2CppType.Of<Panel_IceFishing>(),
               Il2CppType.Of<Panel_IceFishingHoleClear>(),
               Il2CppType.Of<Panel_InsulatedFlask>(),
               Il2CppType.Of<Panel_Inventory>(),
               Il2CppType.Of<Panel_Inventory_Examine>(),
               Il2CppType.Of<Panel_Inventory_Examine_MenuItem>(),
               Il2CppType.Of<Panel_LifeAfterDeath>(),
               Il2CppType.Of<Panel_Log>(),
               Il2CppType.Of<Panel_MainMenu>(),
               Il2CppType.Of<Panel_Map>(),
               Il2CppType.Of<Panel_Milling>(),
               Il2CppType.Of<Panel_MissionsStory>(),
               Il2CppType.Of<Panel_OptionsMenu>(),
               Il2CppType.Of<Panel_PauseMenu>(),
               Il2CppType.Of<Panel_PickUnits>(),
               Il2CppType.Of<Panel_PickWater>(),
               Il2CppType.Of<Panel_RecipeBook>(),
               Il2CppType.Of<Panel_Repair>(),
               Il2CppType.Of<Panel_Rest>(),
               Il2CppType.Of<Panel_SafeCracking>(),
               Il2CppType.Of<Panel_SelectWorldMap>(),
               Il2CppType.Of<Panel_SnowShelterBuild>(),
               Il2CppType.Of<Panel_SnowShelterInteract>(),
               Il2CppType.Of<Panel_SprayPaint>(),
               Il2CppType.Of<Panel_Stats_DetailedEntry>(),
               Il2CppType.Of<Panel_Stats_SummaryEntry>(),
               Il2CppType.Of<Panel_Story_MissionJumpItem>(),
               Il2CppType.Of<Panel_TorchLight>(),
               Il2CppType.Of<Panel_TradeSelection>(),
               Il2CppType.Of<Panel_TutorialPopup>(),
               Il2CppType.Of<Panel_WeaponPicker>(),
          };

        public static bool IsPanelOpen()
        {
            foreach (var panelType in panelTypes)
            {
                if (InterfaceManager.IsPanelEnabled(panelType))
                {
                    return true;
                }
            }

            return false;

        }
    }
}