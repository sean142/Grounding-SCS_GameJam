using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delete", 1.0f);
    }

    // Update is called once per frame
    void Delete(){
        Destroy(this.gameObject);
    }
}
