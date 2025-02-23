# Epic Loot v0.5.14
Author: RandyKnapp
Source: [Github](https://github.com/RandyKnapp/ValheimMods/blob/main/EpicLoot/)

Patch notes: https://github.com/RandyKnapp/ValheimMods/blob/main/EpicLoot/patchnotes.md

This mod aims to add a loot drop experience to Valheim similar to Diablo or other RPGs. Monsters and chests can now drop Magic, Rare, Epic, or Legendary magic items. Each magic item has a number of magic effects on it, that give bonuses to the item or your character when that magic item is equipped.

The mod is currently in ***Early Access***! That means it's **not done**! Be patient as the author adds new features, fixes bugs, and finishes things up. If you want to help, please provide feedback on the [Nexus mod page](https://www.nexusmods.com/valheim/mods/387) or on the [github](https://github.com/RandyKnapp/ValheimMods/tree/main/EpicLoot) for the following:

  * **Bugs** *(check to make sure your bug is new and not already reported)*
  * **Balance Issues** *(drops too strong? Too weak? Ruin the crafting progression?)*
  * **Missing content** *(check the TODO list below to make sure the author isn't already planning to do it)*
  * **Suggestions** for new magic item effects
  * **Suggestions** for something else like UI or art improvements

***EpicLoot works in multiplayer and on dedicated servers!*** The server and all players should have the mod and its dependencies installed.

Information about every magic effect and loot drop table can be found in [info.md](https://github.com/RandyKnapp/ValheimMods/blob/main/EpicLoot/info.md).

## Installation

Copy the contents of "files" to a new folder called "EpicLoot" in your BepInEx/plugins directory.

## Cheats

Enter these into the console (F5) after using `imacheater`:

  * `magicitem <rarity> <itemtype> <amount>`: Roll a random magic item using the specified values. (alias: `mi`)
    * `<rarity>`: (String) One of: magic, rare, epic, legendary, random. If left empty, uses random.
	* `<itemtype>`: (String) The internal ID of an item. May be "random". If left empty, uses random.
	* `<amount>`: (Int) The number of magic items to roll. If the other values are set to random, rerolls that random item each time. If left empty, uses 1.
  * `magicmats`: Spawns a bunch of all the magic crafting materials

## Dependencies

  * **Extended Item Data Framework**: Required. Download from [Nexus](https://www.nexusmods.com/valheim/mods/281]), [Thunderstore](https://valheim.thunderstore.io/package/RandyKnapp/ExtendedItemDataFramework/)

## Current Known Mod Conflicts

  * **BetterUI** ([Nexus](https://www.nexusmods.com/valheim/mods/189), [Thunderstore](https://valheim.thunderstore.io/package/Masa/BetterUI/)): You won't be able to see the magic item properties in the tooltip. Go to the BetterUI config and set `showCustomTooltips = false`.

## Known Bugs

## TODO

- [X] Streamline enchanting UI. Use selectable rarity per item.
- [X] Configurable magic effects
- [X] More exclusions and configurable requirements for magic effects
- [ ] Augment items: change/reroll magic item effects (transmute? modify?)
- [ ] Infuse items: rarity to next rarity (like diablo upgrade rare to legendary)
- [ ] List of active magic effects on the player status screen
- [ ] Limit drop types by actual player progression?
- [ ] Gamble for magic items from Merchant
- [ ] Custom crafting station for enchanting
- [ ] Create effects for in-game models of magic items
- [ ] Balance, balance, balance
- [ ] Move tooltip code to postfix, parse and inject rather than redo from scratch
- [ ] Custom item sets (replace troll too)
- [ ] Rename item if magic (prefix/postfix? Legendary names?)
- [ ] New Runes skill (enchanting)
- [ ] New Seidr skill (for what?)

## Magic Effects:

#### Weapons
- [ ] Paralyze
- [ ] Add Knockback
- [ ] Slow
- [ ] Luck (increase drop rate and rarity chance)
- [ ] Riches (add chance to drop treasure on all mobs)
- [ ] Blink (bow or spear, teleport to impact point)
- [ ] Life steal
- [ ] Exploding shot (bows, deal aoe damage on arrow impact)
- [ ] Multishot (bows, shoot multiple arrows from one)
- [ ] Quick draw (bows, draw speed dramatically increased)
- [ ] Recall (spear, automaticallyl pick up spear after throwing)
- [ ] Immobilize
- [ ] Modify Attack Speed
- [ ] Increase damage vs staggered enemies
- [ ] Duelist (sword, when off hand is empty, increase parry and block power by a lot)
- [ ] Opportunist (knife, add backstab damaged to staggered enemies)
- [ ] Throwing (change alterate attack to throw like spear)
- [ ] Increase stagger duration
- [ ] Blind
- [ ] Immovable (tower shield, immune to stagger and knockback while blocking)
- [ ] Glowing

#### Armor
- [ ] Luck (increase drop rate and rarity chance)
- [ ] Warm (Prevent freezing effect)
- [ ] Waterproof (cape, prevent Wet effect from rain)
- [ ] Waterwalk (legs)
- [ ] Double Jump (legs)
- [ ] Thorns damage
- [ ] Sneak increase (legs)
- [ ] Dodge improvement (legs)
- [ ] Feather Fall (legs)
- [ ] Nightvision (helmet)
- [ ] Discovery radius increase (helmet)
- [ ] Quick learner (helmet, increase xp gain)
- [ ] Increase armor when below HP threshold
- [ ] % chance to stagger attackers
- [ ] % chance to ignore incoming damage
- [ ] Improve Skill Level
- [ ] Comfortable (Increase Comfort level when resting)
- [ ] Glowing

#### Tools
- [ ] Build freedom (hammer, don't require crafting station)
- [ ] No stamina cost

## Legendary Items:

- [ ] Sleipnir's Hoof (Club, increase move speed)
- [ ] Gungnir (Ancient Bark Spear)
- [ ] Mjolnir (Iron Sledge)
- [ ] Skofnung (Iron Sword)
- [ ] Dainslief (Silver Sword)
- [ ] Angurvadal (Sword)
- [ ] Vidar's Shoes (Iron Legs, huge kick damage boost?)
- [ ] Skidbaldnir (ship that can turn into an item)
- [ ] Hofund (Sword, charges with each kill, then discharges on heavy attack)
- [ ] Gjallarhorn (Tankard, when used (how?) makes all enemies flee from the player)

## Basic Item Sets:

## Legendary Sets:

**Author's Note:** This mod uses an image of the Odal rune (ᛟ) to denote set items. It's reconstructed Proto-Germanic meaning is "Heritage" or "Possession" and the author felt like it was the best rune from the Elder Futhark to signify set items. However, the Odal rune with wings or feet was and is used as a Nazi symbol. The author ***UNEQUIVOCALLY CONDEMNS*** Nazis, Nazism, anti-semitism, and white supremacy. Furthermore, those who hold or practice those beliefs are not welcome to use this mod. F\*\*k Nazis.