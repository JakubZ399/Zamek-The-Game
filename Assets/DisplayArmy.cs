using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayArmy : MonoBehaviour
{
    [Header("Friendly")]
    [SerializeField] TextMeshProUGUI friendlyInfatry;
    [SerializeField] TextMeshProUGUI friendlySwordsman;
    [SerializeField] TextMeshProUGUI friendlyPikeman;
    [SerializeField] TextMeshProUGUI friendlyCavalry;
    [SerializeField] TextMeshProUGUI friendlyWizard;

    [Header("Enemy")]
    [SerializeField] TextMeshProUGUI enemyInfatry;
    [SerializeField] TextMeshProUGUI enemySwordsman;
    [SerializeField] TextMeshProUGUI enemyPikeman;
    [SerializeField] TextMeshProUGUI enemyCavalry;
    [SerializeField] TextMeshProUGUI enemyWizard;

    void Start()
    {
        friendlyInfatry.text = ResourceBank.infantryAmount.ToString();
        friendlySwordsman.text = ResourceBank.swordsmanAmount.ToString();
        friendlyPikeman.text = ResourceBank.pikemanAmount.ToString();
        friendlyCavalry.text = ResourceBank.cavalryAmount.ToString();
        friendlyWizard.text = ResourceBank.wizardAmount.ToString();

        enemyInfatry.text = ResourceBank.enemyInfantryAmount.ToString();
        enemySwordsman.text = ResourceBank.enemySwordsmanAmount.ToString();
        enemyPikeman.text = ResourceBank.enemyPikemanAmount.ToString();
        enemyCavalry.text = ResourceBank.enemyCavalryAmount.ToString();
        enemyWizard.text = ResourceBank.enemyWizardAmount.ToString();
    }
}
