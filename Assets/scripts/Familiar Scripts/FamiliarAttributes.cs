using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FamiliarAttributes
{
    public string FamiliarName;
    public Sprite FamiliarSprite;
    public enum Growthtype { Fast, Normal, LateBloomer }; // 1 = Fast; 2= Normal; 3 = Late Bloomer
    public enum FamiliarRarity { Common, Uncommon, Rare, Epic, Legendary, Mythic }; // 1 = Common; 2 = Uncommon; 3 = Rare; 4 = Epic; 5 = Legendary; 6 = Mythic
    public string Skillname;
    public int basehp;
    public int finalhp;
    public int baseatk;
    public int finalatk;
    public int basedef;
    public int finaldef;
    public int basewis;
    public int finalwis;
    public int baseagi;
    public int finalagi;
    public enum FamiliarRace { Paragon, Champion, Highlander, Darklander, Westerner, Easterner, Ape, Lizardman, Dwarf, Goblin, Undead, ImperialArmy };      // 1 = Paragon; 2 = Champion; 3 = Highlander; 4 = Darklander;5 = Westerner; 6 = Easterner; 7 = Ape;   8 = Lizardman; 9 = Dwarf; 10 = Goblin; 11 = Undead; 12 = Imperial Army;
    public enum FamiliarGender { nogender, male, Female };
    public bool IsTradable;  // 0 = untradable; 1 = tradeable
    public bool IsSacrificable; // 0 = unsacrificable; 1 = Sacrificable
    public int FamiliarWorth;
}







