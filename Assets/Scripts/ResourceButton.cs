using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ResourceButton : MonoBehaviour
{
    //cooldown time float
    [Range(1f, 10f)] public float cooldownTimeGold = 1f;
    [Range(1f, 10f)] public float cooldownTimeIron = 1f;
    [Range(1f, 10f)] public float cooldownTimeWood = 1f;
    [Range(1f, 10f)] public float cooldownTimeWheat = 1f;

    [Range(1f, 10f)] public float cooldownTimeSword = 1f;
    [Range(1f, 10f)] public float cooldownTimePike = 1f;
    [Range(1f, 10f)] public float cooldownTimeHorse = 1f;

    //cooldown bool
    public bool isCooldownGold = true;
    public bool isCooldownIron = true;
    public bool isCooldownWood = true;
    public bool isCooldownWheat = true;

    public bool isCooldownSword = true;
    public bool isCooldownPike = true;
    public bool isCooldownHorse = true;

    //start with cooldown
    private void Start()
    {
        Invoke("CooldownGold", cooldownTimeGold);
        Invoke("CooldownIron", cooldownTimeIron);
        Invoke("CooldownWood", cooldownTimeWood);
        Invoke("CooldownWheat", cooldownTimeWheat);

        Invoke("CooldownSword", cooldownTimeSword);
        Invoke("CooldownPike", cooldownTimePike);
        Invoke("CooldownHorse", cooldownTimeHorse);
    }

    //add resource method
    public void AddGoldResource(float cooldownTime)
    {
        if (!isCooldownGold)
        {
            ResourceBank.goldBank++;
            Invoke("CooldownGold", cooldownTime);
        }
        isCooldownGold = true;
    }
    public void AddIronResource(float cooldownTime)
    {
        if (!isCooldownIron)
        {
            ResourceBank.ironBank++;
            Invoke("CooldownIron", cooldownTime);
        }
        isCooldownIron = true;
    }
    public void AddWoodResource(float cooldownTime)
    {
        if (!isCooldownWood)
        {
            ResourceBank.woodBank++;
            Invoke("CooldownWood", cooldownTime);
        }
        isCooldownWood = true;
    }
    public void AddWheatResource(float cooldownTime)
    {
        if (!isCooldownWheat)
        {
            ResourceBank.wheatBank++;
            Invoke("CooldownWheat", cooldownTime);
        }
        isCooldownWheat = true;
    }

    //change resource to weapon method
    public void AddSwordResource(float cooldownTime)
    {
        if (!isCooldownSword && ResourceBank.ironBank > 0)
        {
            ResourceBank.ironBank--;
            ResourceBank.swordBank++;
            Invoke("CooldownSword", cooldownTime);
        }
        isCooldownSword = true;
    }
    public void AddPikeResource(float cooldownTime)
    {
        if (!isCooldownPike && ResourceBank.woodBank > 0)
        {
            ResourceBank.woodBank--;
            ResourceBank.pikeBank++;
            Invoke("CooldownPike", cooldownTime);
        }
        isCooldownPike = true;
    }
    public void AddHorseResource(float cooldownTime)
    {
        if (!isCooldownHorse && ResourceBank.wheatBank > 0)
        {
            ResourceBank.wheatBank--;
            ResourceBank.horseBank++;
            Invoke("CooldownHorse", cooldownTime);
        }
        isCooldownHorse = true;
    }

    //resource cooldown
    public void CooldownGold()
    {
        isCooldownGold = false;
    }
    public void CooldownIron()
    {
        isCooldownIron = false;
    }
    public void CooldownWood()
    {
        isCooldownWood = false;
    }
    public void CooldownWheat()
    {
        isCooldownWheat = false;
    }

    //weapon cooldown
    public void CooldownSword()
    {
        isCooldownSword = false;
    }
    public void CooldownPike()
    {
        isCooldownPike = false;
    }
    public void CooldownHorse()
    {
        isCooldownHorse = false;
    }
}
