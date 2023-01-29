using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WoodMine : MonoBehaviour
{
    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 2f;

    bool isCooldown = true;

    private void OnMouseDown()
    {
        AddResource();
    }

    private void AddResource()
    {
        if (!isCooldown)
        {
            ResourceBank.woodBank++;
            Invoke("Cooldown", cooldownTime);
        }
        isCooldown = true;
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
