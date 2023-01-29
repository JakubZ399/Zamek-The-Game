using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddArmy : MonoBehaviour
{
    public void AddInfatryAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.infantryCostGold)
        {
            ResourceBank.goldBank -= ResourceBank.infantryCostGold;
            ResourceBank.infantryAmount++;
            armyAmount.text = ResourceBank.infantryAmount.ToString();
        }
    }
    public void AddSwordsmanAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.swordsmanCostGold && ResourceBank.swordBank > 0)
        {
            ResourceBank.goldBank -= ResourceBank.swordsmanCostGold;
            ResourceBank.swordBank -= 1;
            ResourceBank.swordsmanAmount++;
            armyAmount.text = ResourceBank.swordsmanAmount.ToString();
        }
    }
    public void AddPikemanAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.pikemanCostGold && ResourceBank.pikeBank > 0)
        {
            ResourceBank.goldBank -= ResourceBank.pikemanCostGold;
            ResourceBank.pikeBank -= 1;
            ResourceBank.pikemanAmount++;
            armyAmount.text = ResourceBank.pikemanAmount.ToString();
        }
    }
    public void AddCavalryAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.cavalryCostGold && ResourceBank.pikeBank > 0 && ResourceBank.wheatBank > 0)
        {
            ResourceBank.goldBank -= ResourceBank.cavalryCostGold;
            ResourceBank.pikeBank -= 1;
            ResourceBank.wheatBank -= 1;
            ResourceBank.cavalryAmount++;
            armyAmount.text = ResourceBank.cavalryAmount.ToString();
        }
    }
    public void AddWizardAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.wizardCostGold)
        {
            ResourceBank.goldBank -= ResourceBank.wizardCostGold;
            ResourceBank.wizardAmount++;
            armyAmount.text = ResourceBank.wizardAmount.ToString();
        }
    }
}
