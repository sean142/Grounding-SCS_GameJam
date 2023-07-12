using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstUIManager : MonoBehaviour
{
    public Animator letterAnimator;

    public GameObject buttonToMoveControlUI;

    public GameObject Room;
    public GameObject Plane;
    public void Awake()
    {
        letterAnimator = GetComponent<Animator>();
        letterAnimator.SetBool("openLetter", true);
    }

    //private void Update()
    //{
    //    if (letterAnimator.GetCurrentAnimatorStateInfo(0).IsName("isOver"))
    //    {
    //        Debug.Log("test");
    //        SecondUIManager.instance.fadeOut.SetActive(true);
    //        SecondUIManager.instance.OpenLetterFadeOut();
    //    }

    //}

    public void LetterAnimationEvent()
    {
        SecondUIManager.instance.fadeOut.SetActive(true);
        SecondUIManager.instance.OpenLetterFadeOut();
        CharacterMovement.canMove = true;
        MouseLook.canMoveScreen = true;
        Room.SetActive(true);
        Plane.SetActive(false);
    }
}
