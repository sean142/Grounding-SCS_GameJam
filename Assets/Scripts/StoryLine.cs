using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryLine : MonoBehaviour
{
    int change;
    bool first, second, third;
    public GameObject firstCube, SecondCube, thirdCube;
    public GameObject firstLetter, sceondLetter, thirdLetter;
    // Start is called before the first frame update
    void Start()
    {
        first = false;
        second = false;
        third = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(firstCube.activeSelf){
            first = true;
        }
        else if(first){
            firstLetter.SetActive(true);
            change = 1;
            Invoke("ExitLetter", 5.0f);
        }

        if(SecondCube.activeSelf){
            second = true;
        }
        else if(second){
            sceondLetter.SetActive(true);
            change = 2;
            Invoke("ExitLetter", 5.0f);
        }

        if(thirdCube.activeSelf){
            third = true;
        }
        else if(third){
            thirdLetter.SetActive(true);
            change = 3;
            Invoke("ExitLetter", 5.0f);
        }

    }

    void ExitLetter(){
        switch (change)
        {
            case 1:
                Destroy(firstLetter);
                first = false;
                break;
            case 2:
                Destroy(sceondLetter);
                second = false;
                break;
            case 3:
                Destroy(thirdLetter);
                third = false;
                break;

        }
    }
}
