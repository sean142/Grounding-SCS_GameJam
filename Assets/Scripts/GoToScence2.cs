using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScence2 : MonoBehaviour
{
    void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
