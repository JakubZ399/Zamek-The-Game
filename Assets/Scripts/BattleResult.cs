using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleResult : MonoBehaviour
{
    [SerializeField] private GameObject victoryUI;
    [SerializeField] private GameObject defeatUI;

    int friendlyScore;
    int enemyScore;

    public int infantryScore = 10;
    public int swordsmanScore = 20;
    public int pikemanScore = 15;
    public int cavalryScore = 25;
    public int wizardScore = 50;

    public int pikemanVsCavalryBonus = 5;
    public int cavalryVsSwordsmanBonus = 10;

    private void Awake()
    {
        victoryUI.SetActive(false);
        defeatUI.SetActive(false);
    }

    void Start()
    {
        CalculateFinalScore(ResourceBank.infantryAmount, ResourceBank.swordsmanAmount, ResourceBank.pikemanAmount, ResourceBank.cavalryAmount, ResourceBank.wizardAmount,
        ResourceBank.enemyInfantryAmount, ResourceBank.enemySwordsmanAmount, ResourceBank.enemyPikemanAmount, ResourceBank.enemyCavalryAmount, ResourceBank.enemyWizardAmount);
        CompareScore();
    }

    int CalculateOurScore(int infantryAmount, int swordsmanAmount, int pikemanAmount, int cavalryAmount, int wizardAmount)
    {
        int friendlyScore = infantryAmount * infantryScore +
                          swordsmanAmount * swordsmanScore +
                          pikemanAmount * pikemanScore +
                          cavalryAmount * cavalryScore +
                          wizardAmount * wizardScore;

        return friendlyScore;
    }

    int CalculateEnemyScore(int infantryAmount, int swordsmanAmount, int pikemanAmount, int cavalryAmount, int wizardAmount)
    {
        int enemyScore = infantryAmount * infantryScore +
                         swordsmanAmount * swordsmanScore +
                         pikemanAmount * pikemanScore +
                         cavalryAmount * cavalryScore +
                         wizardAmount * wizardScore;

        return enemyScore;
    }

    void CalculateFinalScore(int friendlyInfantryAmount, int friendlySwordsmanAmount, int friendlyPikemanAmount, int friendlyCavalryAmount, int friendlyWizardAmount,
                                   int enemyInfantryAmount, int enemySwordsmanAmount, int enemyPikemanAmount, int enemyCavalryAmount, int enemyWizardAmount)
    {
        //bonus unit score against...
        int friendlyPikemanVsCavalry = friendlyPikemanAmount * enemyCavalryAmount * pikemanVsCavalryBonus;
        int enemyPikemanVsCavalry = enemyPikemanAmount * friendlyCavalryAmount * pikemanVsCavalryBonus;

        int friendlyCavalryVsSwordsman = friendlyCavalryAmount * enemySwordsmanAmount * cavalryVsSwordsmanBonus;
        int enemyCavalryVsSwordsman = enemyCavalryAmount * friendlySwordsmanAmount * cavalryVsSwordsmanBonus;

        //calculate score

        friendlyScore = CalculateOurScore(friendlyInfantryAmount, friendlySwordsmanAmount, friendlyPikemanAmount, friendlyCavalryAmount, friendlyWizardAmount)
            + friendlyPikemanVsCavalry + friendlyCavalryVsSwordsman;

        enemyScore = CalculateEnemyScore(enemyInfantryAmount, enemySwordsmanAmount, enemyPikemanAmount, enemyCavalryAmount, enemyWizardAmount)
            +enemyPikemanVsCavalry + enemyCavalryVsSwordsman;


        Debug.Log("Friendly Score: " + friendlyScore);
        Debug.Log("Bonus Pikeman: " + friendlyPikemanVsCavalry + "  Bonus Cavalry: " + friendlyCavalryVsSwordsman);
        Debug.Log("Enemy Score: " + enemyScore);
        Debug.Log("Bonus Pikeman: " + enemyPikemanVsCavalry + "  Bonus Cavalry: " + enemyCavalryVsSwordsman);
    }

    void CompareScore()
    {
        if (friendlyScore > enemyScore)
        {
            victoryUI.SetActive(true);
        }
        else if(friendlyScore <= enemyScore)
        {
            defeatUI.SetActive(true);
        }
    }
}
