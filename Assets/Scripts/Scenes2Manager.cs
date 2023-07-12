using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes2Manager : MonoBehaviour
{
    public AudioSource GrilAudio;
   public void AnimationEventGirl()
   {
        GrilAudio.Play();
   }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
