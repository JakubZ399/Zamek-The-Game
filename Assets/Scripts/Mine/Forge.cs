using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Forge : MonoBehaviour
{
    //resource bank script
    ResourceBank resourceBank;

    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 3f;

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
        if (resourceBank.ironBank > 0 && isCooldown == false)
        {
            isCooldown = true;
            resourceBank.ironBank -= 1;
            resourceBank.sword += 1;
            Invoke("Cooldown", cooldownTime);
        }
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
