using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Forge : MonoBehaviour
{

    //cooldown var
    [Header("Cooldown")]
    [SerializeField][Range(0.5f, 20f)] float cooldownTime = 3f;

    bool isCooldown = false;

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
        if (ResourceBank.ironBank > 0 && isCooldown == false)
        {
            isCooldown = true;
            ResourceBank.ironBank -= 1;
            ResourceBank.swordBank += 1;
            Invoke("Cooldown", cooldownTime);
        }
    }

    private void Cooldown()
    {
        isCooldown = false;
    }
}
