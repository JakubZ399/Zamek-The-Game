using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheatFarm : MonoBehaviour
{
    //resource bank script
    ResourceBank resourceBank;

    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 2f;

    bool isCooldown = false;

    private void Start()
    {
        resourceBank = FindObjectOfType<ResourceBank>();
    }

    private void OnMouseDown()
    {
        AddResource();
    }

    private void AddResource()
    {
        if (!isCooldown)
        {
            ResourceBank.wheatBank++;
            Invoke("Cooldown", cooldownTime);
        }
        isCooldown = true;
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
