using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    [Header("Resource")]
    public static int goldBank = 0;
    public static int ironBank = 0;
    public static int woodBank = 0;
    public static int wheatBank = 0;

    [Header("Weapon")]
    public static int swordBank = 0;
    public static int pikeBank = 0;
    public static int horseBank = 0;

    [Header("Army")]
    public static int infantryAmount = 0;
    public static int infantryCostGold;
    [Range(1,50)] public int infantryCost;

    public static int swordsmanAmount = 0;
    public static int swordsmanCostGold;
    [Range(1, 50)] public int swordsmanCost;

    public static int pikemanAmount = 0;
    public static int pikemanCostGold;
    [Range(1, 50)] public int pikemanCost;

    public static int cavalryAmount = 0;
    public static int cavalryCostGold;
    [Range(1, 50)] public int cavalryCost;

    public static int wizardAmount = 0;
    public static int wizardCostGold;
    [Range(1, 50)] public int wizardCost;

    private void Awake()
    {
        infantryCostGold = infantryCost;
        swordsmanCostGold = swordsmanCost;
        pikemanCostGold = pikemanCost;
        cavalryCostGold = cavalryCost;
        wizardCostGold = wizardCost;
    }
}

