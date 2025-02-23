## Version 0.5.14
  * Updating the console command with a few more exclusions
  * Modified a UI display to better support multiple hotkeybars and multiple inventory grids
## Version 0.5.13
  * Made it slightly easier for other modders to access the enchanting and disenchanting information
  * Made the tooltip text lookup for set items more defensive to prevent some mod conflicts
## Version 0.5.12
  * Enchanting an item maintains its current durability percentage
  * Enchanting uses a new UI flow and shows the item after you enchant it
  * Magic Item Effects now load from a config file
  * Magic Item Effects now use a string ID instead of an enum
  * Changing TreasureChest_plains_stone loottable to use the TreasureChest_heath table
  * Fixed mod conflict with PlantingPlus
## Version 0.5.11
  * Fixed a bug where crafter name would be applied to upgraded objects
  * Upgraded objects automatically repaired to full durability
  * Changing the default rarity of Dverger Circlet, Megingjord, and Wishbone to Rare
  * Fixing a bug where Eikthyr (or some other mob, like Troll lvl 3) dies repeatedly
## Version 0.5.10
  * Removing all cheat and dlc items from the random loot generation cheat	
  * Fixed a bug that showed 0% chance for all magic effect counts while enchanting	
  * Fixed a bug that caused some chests to spawn non-magical items	
  * Updated loot tables with feedback from comments:
    * Chitin weapons moved to tier 2 weapons
    * Draugr Fang added to tier 4 weapons
    * Wolf Cape added to tier 4 armor
    * Added more options to Troll
    * Added more tier 3 drops to swamp mobs
    * Increased drop chance for Fuling Berserker and Fuling Shaman
    * Reduced loot tiers, increased drop chance counts for Serpent
    * Fixed treasure chests so they properly reflected their biome (`plains_stone` is actually Black Forest, `heath` is Plains)
    * Reduced loot tiers for `meadows_buried` and `shipwreck_karve` chests (they still have higher rarity chances)
## Version 0.5.9
  * Fixed bug where sacrificing with nearly full inventory resulted in lost items (items that do not fit in the inventory now fall to the ground)	
  * Loot2 and Loot3 in the loot table are now exclusive (e.g. if the mob is level 2, and Loot2 is present, then only the loot from Loot2 is used, otherwise it falls back to Loot)	
  * ItemSets have been added to the loot table schema (If the "Item" field of the Loot list is in the item set, roll on that loot table for that item instead)	
  * Can now reference other loot tables in the loot table item config using "Item": "`object`.`level`" where `object` is the name of a loot table entry and `level` is an integer between 1 and 3 that refers to Loot, Loot2, or Loot3.	
  * Number of magic effects per rarity is now configurable in loottables.json in the "MagicEffectsCount" object	
  * Completed loottables with updates from feedback and using the new system	
## Version 0.5.8
  * Hiding console commands behind the cheat flag	
  * Removing log spam	
## Version 0.5.7
  * Removing accidentally added debug object	
## Version 0.5.6
  * Fixing crafting tabs showing magic items	
  * Changing crafting tab item description to scrolling (can turn off in config)	
  * Can set display name of rarity types in config	
  * Can put non-magic items in the loot table by omitting the Rarity chance array	
  * Loot beam sounds now respect the in-game SFX volume setting	
## Version 0.5.5
  * Fixed yet another couple of crafting tab bugs	
  * Reduced mats upgrade recipe to 5:1	
  * Added shard to same rarity dust/essence/reagent recipe at 2:1	
  * Increased drop chance on The Elder and Bonemass	
  * Fixed crafting recipe list selection exploit/bug	
  * Added special recipe to sacrifice Swamp Key (who needs more than one?)	
## Version 0.5.4
  * Fixed bug with viewing effect ranges	
  * Added troll trophy to rare disenchant list	
  * Moved greydwarf brute and shaman trophy to rare disenchant list	
  * Fixed an icon bug where the new material message showed the red material icon	
  * Fixed some bugs with the crafting tabs	
## Version 0.5.3
  * Fixed stamina regen and health regen	
  * Added holding shift to see ranges in tooltips	
  * Fixed Elder/Bonemass runestone rarity mixup	
## Version 0.5.2
  * Fix for an enchant exploit	
  * Updated swamp loot tables	
  * Fixed resistances not working at all	
## Version 0.5.1
  * Fixed never respawning after dying	
  * Fixed a bug where a whole stack of trophies would be disenchanted for a single crafting material	
  * Updated correct ## Version number everywhere