using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Stable : MonoBehaviour
{
    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 3f;

    bool isCooldown = true;

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
        if (ResourceBank.wheatBank > 0 && isCooldown == false)
        {
            isCooldown = true;
            ResourceBank.wheatBank -= 1;
            ResourceBank.horseBank += 1;
            Invoke("Cooldown", cooldownTime);
        }
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
