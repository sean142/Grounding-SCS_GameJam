using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDebug : MonoBehaviour
{
    public GameObject Scence1, Scence2; 
    public Animator animator_Beep, animator_Chainsaw, animator_Hoe;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Scence1.activeSelf || Scence2.activeSelf){
            animator_Hoe.SetBool("HoeATK", false);
            animator_Chainsaw.SetBool("ChainsawATK", false);
            animator_Beep.SetBool("BeepATK", false);
        }
    }
}
