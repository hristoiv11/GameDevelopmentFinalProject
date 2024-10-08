using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSwitch : MonoBehaviour
{
    public GameObject[] guns; // Array to hold different gun prefabs
    private int currentGunIndex = 0;

    void Start()
    {
        // Initially, enable the first gun and disable others
        for (int i = 0; i < guns.Length; i++)
        {
            guns[i].SetActive(i == currentGunIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) // Press Q to switch guns
        {
            SwitchGun();
        }
    }

    void SwitchGun()
    {
        // Disable the current gun
        guns[currentGunIndex].SetActive(false);

        // Increment the gun index and wrap around if necessary
        currentGunIndex = (currentGunIndex + 1) % guns.Length;

        // Enable the new gun
        guns[currentGunIndex].SetActive(true);
    }
}
