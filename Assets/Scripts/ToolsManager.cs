using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsManager : MonoBehaviour
{
    int Number;
    public static int CurrentNumber;

    public void Update()
    {
        CurrentNumber = Number;
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tool_1":
                Number = 1;
                SecondUIManager.instance.CheckUseTools.SetActive(true);
                break;

            case "Tool_2":
                Number = 2;
                SecondUIManager.instance.CheckUseTools.SetActive(true);
                break;

            case "Tool_3":
                Number = 3;
                SecondUIManager.instance.CheckUseTools.SetActive(true);
                break;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tool_1":
                SecondUIManager.instance.CheckUseTools.SetActive(false);
                break;

            case "Tool_2":
                SecondUIManager.instance.CheckUseTools.SetActive(false);
                break;

            case "Tool_3":
                SecondUIManager.instance.CheckUseTools.SetActive(false);
                break;
        }
    }
}
