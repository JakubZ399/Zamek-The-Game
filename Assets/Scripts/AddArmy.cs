using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddArmy : MonoBehaviour
{
    public bool isCooldownInfatry = false;
    public bool isCooldownSwordsman = false;
    public bool isCooldownPikeman = false;
    public bool isCooldownCavalry = false;
    public bool isCooldownWizard = false;

    public float unitSpawnCooldown = 5f;

    public void AddInfatryAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.infantryCostGold && !isCooldownInfatry)
        {
            isCooldownInfatry = true;
            ResourceBank.goldBank -= ResourceBank.infantryCostGold;
            ResourceBank.infantryAmount++;
            armyAmount.text = ResourceBank.infantryAmount.ToString();
            Invoke("CooldownInfantry", unitSpawnCooldown);
        }
    }
    public void AddSwordsmanAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.swordsmanCostGold && ResourceBank.swordBank > 0 && !isCooldownSwordsman)
        {
            isCooldownSwordsman = true;
            ResourceBank.goldBank -= ResourceBank.swordsmanCostGold;
            ResourceBank.swordBank -= 1;
            ResourceBank.swordsmanAmount++;
            armyAmount.text = ResourceBank.swordsmanAmount.ToString();
            Invoke("CooldownSwordsman", unitSpawnCooldown);
        }
    }
    public void AddPikemanAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.pikemanCostGold && ResourceBank.pikeBank > 0 && !isCooldownPikeman)
        {
            isCooldownPikeman = true;
            ResourceBank.goldBank -= ResourceBank.pikemanCostGold;
            ResourceBank.pikeBank -= 1;
            ResourceBank.pikemanAmount++;
            armyAmount.text = ResourceBank.pikemanAmount.ToString();
            Invoke("CooldownPikeman", unitSpawnCooldown);
        }
    }
    public void AddCavalryAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.cavalryCostGold && ResourceBank.pikeBank > 0 && ResourceBank.wheatBank > 0 && !isCooldownCavalry)
        {
            isCooldownCavalry = true;
            ResourceBank.goldBank -= ResourceBank.cavalryCostGold;
            ResourceBank.pikeBank -= 1;
            ResourceBank.wheatBank -= 1;
            ResourceBank.cavalryAmount++;
            armyAmount.text = ResourceBank.cavalryAmount.ToString();
            Invoke("CooldownCavalry", unitSpawnCooldown);
        }
    }
    public void AddWizardAmount(TextMeshProUGUI armyAmount)
    {
        if (ResourceBank.goldBank >= ResourceBank.wizardCostGold && ResourceBank.ironBank > 0 && ResourceBank.woodBank > 1 &&
            ResourceBank.wheatBank > 0 && ResourceBank.swordBank > 0 && ResourceBank.pikeBank > 0 && ResourceBank.horseBank > 0 && !isCooldownWizard)
        {
            isCooldownWizard = true;
            ResourceBank.goldBank -= ResourceBank.wizardCostGold;
            ResourceBank.ironBank -= 1;
            ResourceBank.woodBank -= 1;
            ResourceBank.wheatBank -= 1;

            ResourceBank.swordBank -= 1;
            ResourceBank.pikeBank -= 1;
            ResourceBank.horseBank -= 1;

            ResourceBank.wizardAmount++;
            armyAmount.text = ResourceBank.wizardAmount.ToString();
            Invoke("CooldownWizard", unitSpawnCooldown);
        }
    }

    public void CooldownInfantry()
    {
        isCooldownInfatry = false;
    }
    public void CooldownSwordsman()
    {
        isCooldownSwordsman = false;
    }
    public void CooldownPikeman()
    {
        isCooldownPikeman = false;
    }
    public void CooldownCavalry()
    {
        isCooldownCavalry = false;
    }
    public void CooldownWizard()
    {
        isCooldownWizard = false;
    }
}
