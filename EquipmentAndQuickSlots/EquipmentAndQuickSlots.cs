﻿using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;

namespace EquipmentAndQuickSlots
{
    [BepInPlugin(PluginId, "Equipment and Quick Slots", "2.0.0")]
    [BepInDependency("moreslots", BepInDependency.DependencyFlags.SoftDependency)]
    public class EquipmentAndQuickSlots : BaseUnityPlugin
    {
        public const string PluginId = "randyknapp.mods.equipmentandquickslots";

        public const int QuickSlotCount = 3;
        public static int EquipSlotCount => EquipSlotTypes.Count;
        public static readonly ConfigEntry<string>[] KeyCodes = new ConfigEntry<string>[QuickSlotCount];
        public static readonly ConfigEntry<string>[] HotkeyLabels = new ConfigEntry<string>[QuickSlotCount];
        public static readonly List<ItemDrop.ItemData.ItemType> EquipSlotTypes = new List<ItemDrop.ItemData.ItemType>() {
            ItemDrop.ItemData.ItemType.Helmet,
            ItemDrop.ItemData.ItemType.Chest,
            ItemDrop.ItemData.ItemType.Legs,
            ItemDrop.ItemData.ItemType.Shoulder,
            ItemDrop.ItemData.ItemType.Utility
        };

        public static ConfigEntry<bool> EquipmentSlotsEnabled;
        public static ConfigEntry<bool> QuickSlotsEnabled;
        private static ConfigEntry<bool> _loggingEnabled;

        private static EquipmentAndQuickSlots _instance;
        private Harmony _harmony;

        private void Awake()
        {
            _instance = this;

            _loggingEnabled = Config.Bind("Logging", "Logging Enabled", false, "Enable logging");
            KeyCodes[0] = Config.Bind("Hotkeys", "Quick slot hotkey 1", "z", "Hotkey for Quick Slot 1.");
            KeyCodes[1] = Config.Bind("Hotkeys", "Quick slot hotkey 2", "v", "Hotkey for Quick Slot 2.");
            KeyCodes[2] = Config.Bind("Hotkeys", "Quick slot hotkey 3", "b", "Hotkey for Quick Slot 3.");
            HotkeyLabels[0] = Config.Bind("Hotkeys", "Quick slot hotkey label 1", "", "Hotkey Label for Quick Slot 1. Leave blank to use the hotkey itself.");
            HotkeyLabels[1] = Config.Bind("Hotkeys", "Quick slot hotkey label 2", "", "Hotkey Label for Quick Slot 2. Leave blank to use the hotkey itself.");
            HotkeyLabels[2] = Config.Bind("Hotkeys", "Quick slot hotkey label 3", "", "Hotkey Label for Quick Slot 3. Leave blank to use the hotkey itself.");
            EquipmentSlotsEnabled = Config.Bind("Toggles", "Enable Equipment Slots", true, "Enable the equipment slots. !!! WARNING !!! If you disable this while wearing equipment, you will LOSE IT!");
            QuickSlotsEnabled = Config.Bind("Toggles", "Enable Quick Slots", true, "Enable the quick slots. !!! WARNING !!! If you disable this while items are in the quickslots, you will LOSE THEM!");

            _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginId);
        }

        private void OnDestroy()
        {
            _harmony?.UnpatchAll(PluginId);
        }

        private void Update()
        {
            if (QuickSlotsEnabled.Value)
            {
                var player = Player.m_localPlayer;
                if (player != null && player.TakeInput())
                {
                    for (int i = 0; i < QuickSlotCount; ++i)
                    {
                        CheckQuickUseInput(player, i);
                    }
                }
            }
        }

        public static void Log(string message)
        {
            if (_loggingEnabled.Value)
            {
                _instance.Logger.LogMessage(message);
            }
        }

        public static void LogWarning(string message)
        {
            if (_loggingEnabled.Value)
            {
                _instance.Logger.LogWarning(message);
            }
        }

        public static void LogError(string message)
        {
            if (_loggingEnabled.Value)
            {
                _instance.Logger.LogError(message);
            }
        }

        public static string GetBindingLabel(int index)
        {
            index = Mathf.Clamp(index, 0, QuickSlotCount - 1);
            var keycode = GetBindingKeycode(index);
            var label = HotkeyLabels[index]?.Value;
            if (string.IsNullOrEmpty(label))
            {
                return string.IsNullOrEmpty(keycode) ? "" : keycode.ToUpperInvariant();
            }
            else
            {
                return label;
            }
        }

        public static string GetBindingKeycode(int index)
        {
            index = Mathf.Clamp(index, 0, QuickSlotCount - 1);
            return KeyCodes[index] == null ? null : KeyCodes[index].Value.ToLowerInvariant();
        }

        public static void CheckQuickUseInput(Player player, int index)
        {
            var keyCode = GetBindingKeycode(index);
            if (keyCode != null && Input.GetKeyDown(keyCode))
            {
                var item = player.GetQuickSlotItem(index);
                if (item != null)
                {
                    player.UseItem(null, item, false);
                }
            }
        }

        public static ItemDrop.ItemData.ItemType GetEquipmentTypeForSlot(int index)
        {
            if (index < 0 || index >= EquipSlotTypes.Count)
            {
                return ItemDrop.ItemData.ItemType.None;
            }

            return EquipSlotTypes[index];
        }

        public static Vector2i GetEquipmentSlotForType(ItemDrop.ItemData.ItemType type)
        {
            return new Vector2i(EquipSlotTypes.IndexOf(type), 0);
        }

        public static bool IsSlotEquippable(ItemDrop.ItemData item)
        {
            return EquipSlotTypes.Contains(item.m_shared.m_itemType);
        }
    }
}
