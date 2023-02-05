using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    //resource static
    [Header("Resource")]
    public static int goldBank;
    public static int ironBank;
    public static int woodBank;
    public static int wheatBank;

    [Header("Weapon")]
    public static int swordBank;
    public static int pikeBank;
    public static int horseBank;

    //resource
    [Header("Resource")]
    [SerializeField] private int goldBankStart = 0;
    [SerializeField] private int ironBankStart = 0;
    [SerializeField] private int woodBankStart = 0;
    [SerializeField] private int wheatBankStart = 0;

    [Header("Weapon")]
    [SerializeField] private int swordBankStart = 0;
    [SerializeField] private int pikeBankStart = 0;
    [SerializeField] private int horseBankStart = 0;

    //army
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


    //enemy army set static
    public static int enemyInfantryAmount;
    public static int enemySwordsmanAmount;
    public static int enemyPikemanAmount;
    public static int enemyCavalryAmount;
    public static int enemyWizardAmount;

    //enemy army set in inspector
    [Header("Enemy Amount On Level Start")]
    [SerializeField][Range(0, 100)] private int enemyInfantryAmountStart = 10;
    [SerializeField][Range(0, 100)] private int enemySwordsmanAmountStart = 0;
    [SerializeField][Range(0, 100)] private int enemyPikemanAmountStart = 0;
    [SerializeField][Range(0, 100)] private int enemyCavalryAmountStart = 0;
    [SerializeField][Range(0, 100)] private int enemyWizardAmountStart = 0;

    private void Awake()
    {
        infantryCostGold = infantryCost;
        swordsmanCostGold = swordsmanCost;
        pikemanCostGold = pikemanCost;
        cavalryCostGold = cavalryCost;
        wizardCostGold = wizardCost;

        enemyInfantryAmount = enemyInfantryAmountStart;
        enemySwordsmanAmount = enemySwordsmanAmountStart;
        enemyPikemanAmount = enemyPikemanAmountStart;
        enemyCavalryAmount = enemyCavalryAmountStart;
        enemyWizardAmount = enemyWizardAmountStart;

        goldBank = goldBankStart;
        ironBank = ironBankStart;
        woodBank = woodBankStart;
        wheatBank = wheatBankStart;
        swordBank = swordBankStart;
        pikeBank = pikeBankStart;
        horseBank = horseBankStart;
    }

    private void Start()
    {
        infantryAmount = 0;
        swordsmanAmount = 0;
        pikemanAmount = 0;
        cavalryAmount = 0;
        wizardAmount = 0;
    }
}

