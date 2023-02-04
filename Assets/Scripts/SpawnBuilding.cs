using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class SpawnBuilding : MonoBehaviour
{
    [SerializeField] private GameObject buildingToSpawn;
    [SerializeField] private float hammerCooldownTime = 10;
    public GameObject buttonResource;
    public GameObject buttonBuild;

    private bool isBuild = false;
    private bool isCooldown = false;

    private void Start()
    {
        isBuild = false;
        buttonResource.SetActive(false);
        buttonBuild.SetActive(true);
    }

    //spawn building
    private void OnMouseDown()
    {
        Debug.Log(Hammer.isHammer);
        if (Hammer.isHammer == true && isBuild == false && Hammer.isCooldown == false)
        {
            Instantiate(buildingToSpawn, transform.position, Quaternion.identity);
            buttonResource.SetActive(true);
            buttonBuild.SetActive(false);
            isBuild = true;

            //hammer cooldown
            Hammer.isCooldown = true;
            Invoke("Cooldown", hammerCooldownTime);

            gameObject.SetActive(false);
        }
    }

    private void Cooldown()
    {
        Hammer.isCooldown = false;
    }
}
