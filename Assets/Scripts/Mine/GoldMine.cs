using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldMine : MonoBehaviour
{
    //resource bank script
    ResourceBank resourceBank;

    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 2f;

    bool isCooldown = false;

    private void Awake()
    {
        resourceBank = FindObjectOfType<ResourceBank>();
    }

    void Start()
    {
        Invoke("Cooldown", cooldownTime);
    }

    private void OnMouseDown()
    {
        AddResource();
    }

    private void AddResource()
    {
        if (!isCooldown)
        {
            resourceBank.goldBank++;
            Invoke("Cooldown", cooldownTime);
        }
        isCooldown = true;
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
