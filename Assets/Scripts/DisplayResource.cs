using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayResource : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI goldUI;
    public TextMeshProUGUI ironUI;
    public TextMeshProUGUI woodUI;
    public TextMeshProUGUI wheatUI;


    public TextMeshProUGUI swordUI;
    public TextMeshProUGUI pikeUI;
    public TextMeshProUGUI horseUI;

    void Update()
    {
        goldUI.text = "Gold: " + ResourceBank.goldBank.ToString();
        ironUI.text = "Iron: " + ResourceBank.ironBank.ToString();
        woodUI.text = "Wood: " + ResourceBank.woodBank.ToString();
        wheatUI.text = "Wheat: " + ResourceBank.wheatBank.ToString();

        swordUI.text = "Sword: " + ResourceBank.swordBank.ToString();
        pikeUI.text = "Pike: " + ResourceBank.pikeBank.ToString();
        horseUI.text = "Horse: " + ResourceBank.horseBank.ToString();
    }
}
