using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Familiar", menuName = "Familiar")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite FamiliarSprite;
    public Growthtype growtype;
    public enum Growthtype { Fast, Normal, LateBloomer }; // 1 = Fast; 2= Normal; 3 = Late Bloomer
    public FamiliarRarity Rarity;
    public enum FamiliarRarity { Common, Uncommon, Rare, Epic, Legendary, Mythic }; // 1 = Common; 2 = Uncommon; 3 = Rare; 4 = Epic; 5 = Legendary; 6 = Mythic
    public string Skillname;
    public string SkillDescription;
    public bool ISAutoAttackPositionDependent;
    public int currentstarlevel;
    public int maxstarlvl;
    public AutoAttackType AttackType;
    public enum AutoAttackType { atk, wis };
    public int AutoAttackDamage;
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
    public int familiarLevel;
    public FamiliarRace race;
    public enum FamiliarRace { Paragon, Champion, Highlander, Darklander, Westerner, Easterner, Ape, Lizardman, Dwarf, Goblin, Undead, ImperialArmy };      // 1 = Paragon; 2 = Champion; 3 = Highlander; 4 = Darklander;5 = Westerner; 6 = Easterner; 7 = Ape;   8 = Lizardman; 9 = Dwarf; 10 = Goblin; 11 = Undead; 12 = Imperial Army;
    public FamiliarGender gender;
    public enum FamiliarGender { nogender, male, Female };
    public bool IsTradable;  // 0 = untradable; 1 = tradeable
    public bool IsSacrificable; // 0 = unsacrificable; 1 = Sacrificable
    public int FamiliarWorth;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MaxlvlCalc();
    }
    public void MaxlvlCalc()
 
    {
     
        //(int)FamiliarRarity.Common == 0
       /* if ((int)FamiliarRarity.Common == 0)

        {
            familiarmaxlvl = 30;
        }
        if ((int)FamiliarRarity.Uncommon == 1)

        {
            familiarmaxlvl = 40;
        }
        if ((int)FamiliarRarity.Rare == 2)

        {
            familiarmaxlvl = 70;
        }
        if ((int)FamiliarRarity.Epic == 3)

        {
            familiarmaxlvl = 99;
        }
        if ((int)FamiliarRarity.Legendary == 4)

        {
            familiarmaxlvl = 99;
        }
        if ((int)FamiliarRarity.Mythic == 5)

        {
            familiarmaxlvl = 99;
        }
        */
    }
}


