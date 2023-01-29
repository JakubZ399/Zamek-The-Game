using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class SpawnBuilding : MonoBehaviour
{
    [SerializeField] private GameObject buildingToSpawn;
    [SerializeField] private float hammerCooldownTime = 15;

    private bool isBuild = false;
    private bool isCooldown = false;

    private void OnMouseDown()
    {
        Debug.Log(Hammer.isHammer);
        if (Hammer.isHammer == true && isBuild == false && Hammer.isCooldown == false)
        {
            Instantiate(buildingToSpawn, transform.position, Quaternion.identity);
            isBuild = true;

            Debug.Log("Build: " + buildingToSpawn);

            Hammer.isCooldown = true;
            Invoke("Cooldown", hammerCooldownTime);

            Debug.Log("Hammer Cooldown: " + hammerCooldownTime);
        }
    }

    private void Cooldown()
    {
        Debug.Log("No Hammer Cooldown");
        Hammer.isCooldown = false;
    }
}
