using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControl : MonoBehaviour
{
    public Animator animator_Beep, animator_Chainsaw, animator_Hoe;
    public GameObject Beep, Chainsaw, Hoe;
    public AudioSource audio_Beep, audio_Chainsaw, audio_Hoe;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // attack aminate
        if (Input.GetMouseButtonDown(0)){
            switch (WeaponControl.current)
            {
                case 1:
                    if (Hoe.activeSelf)
                    {
                        animator_Hoe.SetBool("HoeATK", true);
                        Instantiate(audio_Hoe);
                        Invoke("animateEnd", 0.4f);
                    }
                    
                    break;
                case 2:
                    if (Chainsaw.activeSelf)
                    {
                        animator_Chainsaw.SetBool("ChainsawATK", true);
                        Instantiate(audio_Chainsaw);
                        Invoke("animateEnd", 0.2f);
                    }
                    
                    break; 
                case 3:
                    if (Beep.activeSelf)
                    {
                        animator_Beep.SetBool("BeepATK", true);
                        Instantiate(audio_Beep);
                        Invoke("animateEnd", 0.2f);
                    }
                    
                    break;
                default:
                    Debug.Log("default");
                    break;
            }
        }
    }

    void animateEnd()
    {
        // if_audio_play = false;
        switch (WeaponControl.current)
        {
            case 1:
                animator_Hoe.SetBool("HoeATK", false);
                break;
            case 2:
                animator_Chainsaw.SetBool("ChainsawATK", false);
                break; 
            case 3:
                animator_Beep.SetBool("BeepATK", false);
                break;

            default:
                Debug.Log("default");
                break;
        }
    }
}
