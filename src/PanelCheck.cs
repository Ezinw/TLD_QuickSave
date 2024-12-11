using Il2Cpp;
using Il2CppInterop.Runtime;

namespace QuickSave
{
    public static class PanelCheck
    {
        public static bool IsPanelOpen()
        {
            return InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_ActionPicker>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Actions>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_ActionsRadial>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Affliction>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Badges>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Base>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_BedRollSelect>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_BodyHarvest>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_BodyHarvest_MenuItem>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_BreakDown>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Camera>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_CanOpening>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Clothing>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Confirmation>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Container>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Cooking>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_CookWater>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Crafting>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Credits>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_CuringStorage>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Diagnosis>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_ExchangeBox>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Extras>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_FeedFire>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_FireStart>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_FirstAid>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_GearSelect>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Harvest>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Help>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_IceFishing>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_IceFishingHoleClear>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_InsulatedFlask>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Inventory>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Inventory_Examine>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Inventory_Examine_MenuItem>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_LifeAfterDeath>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Log>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_MainMenu>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Map>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Milling>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_MissionsStory>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_OptionsMenu>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_PauseMenu>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_PickUnits>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_PickWater>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_RecipeBook>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Repair>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Rest>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_SafeCracking>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_SelectWorldMap>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_SnowShelterBuild>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_SnowShelterInteract>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_SprayPaint>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Stats_DetailedEntry>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Stats_SummaryEntry>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_Story_MissionJumpItem>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_TorchLight>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_TradeSelection>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_TutorialPopup>()) ||
                   InterfaceManager.IsPanelEnabled(Il2CppType.Of<Panel_WeaponPicker>());
        }
    }
}