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
        goldUI.text = ResourceBank.goldBank.ToString();
        ironUI.text = ResourceBank.ironBank.ToString();
        woodUI.text = ResourceBank.woodBank.ToString();
        wheatUI.text = ResourceBank.wheatBank.ToString();

        swordUI.text = ResourceBank.swordBank.ToString();
        pikeUI.text = ResourceBank.pikeBank.ToString();
        horseUI.text = ResourceBank.horseBank.ToString();
    }
}
