using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    public AudioSource audioMenu;

    private void Start()
    {
        audioMenu = GetComponent<AudioSource>();
    }

    void OnClick()
    {
        audioMenu.Play();
    }
}
