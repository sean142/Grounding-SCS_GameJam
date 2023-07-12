using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondUIManager : MonoBehaviour
{
    public static SecondUIManager instance;

    public CanvasGroup fadeCanvasGroup;
    public float restartTimer;
    public GameObject fadeOut;
    public GameObject CheckUseTools;       //使用武器確定鍵
    public GameObject letter;   //信件
    public GameObject moveControlUI;   // 操作教學UI
    public GameObject mouseMoveUI;
    public static bool changeWeapon = false; // 換武器用
    public GameObject scenesCubes;      // 管理場景中的cube
    public GameObject scenesTools;    // 管理場景中的tools  
    public GameObject BackGroundWordUI; 

    public void Awake()
    {
        instance = this;
        fadeCanvasGroup = GetComponent<CanvasGroup>();
       
        fadeOut.SetActive(false);
        scenesCubes.SetActive(false);
    }

    public void OpenFadeOut()
    {
        StartCoroutine(FadeOutScene());
    }

    public void OpenLetterFadeOut()
    {
        StartCoroutine(LetterFadeOutScene());
    }

    IEnumerator FadeOutScene()
    {
        CheckUseTools.SetActive(false);

        float currentTime = 0f;
        while (currentTime < restartTimer)
        {
            currentTime += Time.deltaTime;
            fadeCanvasGroup.alpha = 0 + (currentTime / restartTimer);
            yield return null;
        }
        fadeCanvasGroup.alpha = 1;


        StartCoroutine(FadeInScene());
    }

    IEnumerator FadeInScene()
    {
        float currentTime = restartTimer;
        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            fadeCanvasGroup.alpha = currentTime / restartTimer;
            yield return null;
        }
        fadeCanvasGroup.alpha = 0;

        fadeOut.SetActive(false);
    }

    IEnumerator LetterFadeOutScene()
    {
        letter.SetActive(false);

        float currentTime = 0f;
        while (currentTime < restartTimer)
        {
            currentTime += Time.deltaTime;
            fadeCanvasGroup.alpha = 0 + (currentTime / restartTimer);
            yield return null;
        }
        fadeCanvasGroup.alpha = 1;

        mouseMoveUI.SetActive(true);
        StartCoroutine(LetterFadeInScene());
    }

    IEnumerator LetterFadeInScene()
    {
        float currentTime = restartTimer;
        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            fadeCanvasGroup.alpha = currentTime / restartTimer;
            yield return null;
        }
        fadeCanvasGroup.alpha = 0;

        fadeOut.SetActive(false);
    }

    public void OnButtonOnClik(int index)
    {
        // 更換武器UI
        if(index == 0)
        {
            changeWeapon = true;
            fadeOut.SetActive(true);
            OpenFadeOut();
        }
        //關閉滑鼠UI 打開移動UI
        if(index == 1)
        {
            mouseMoveUI.SetActive(false);
            moveControlUI.SetActive(true);
        }

        if (index == 2)
        {
            moveControlUI.SetActive(false);
            scenesCubes.SetActive(true);
            scenesTools.SetActive(true);
        }

        // 關閉CheckUseToolsUI
        if(index == 3)
        {
            CheckUseTools.SetActive(false);
        }

        if(index == 4)
        {
            BackGroundWordUI.SetActive(false);
            letter.SetActive(true);
        }
    }
}
