using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{   

    int CurrentWeapon = -1;
    public GameObject[] weapons;
    public static int current;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(SecondUIManager.changeWeapon)
        {
            Invoke("ChangeWeapon", 1f);
            SecondUIManager.changeWeapon = false;
        }
    }

    private void ChangeWeapon()
    {
        Debug.Log("Change Weapon");
        if(CurrentWeapon != -1){
            weapons[CurrentWeapon].SetActive(false);
        }
        CurrentWeapon = ToolsManager.CurrentNumber-1;
        current = CurrentWeapon+1;
        weapons[CurrentWeapon].SetActive(true);
    }
}
