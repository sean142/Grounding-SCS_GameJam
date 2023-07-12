using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // type of cube
    public GameObject[] cubeGameObjects;
    int currentLayer, destroyThreshold = 3, clickCount;
    public static bool clear = false;
    int toolNumber, temp = -1;
    float attackThreshold = 5.0f;
    GameObject player;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        currentLayer = 1;
        player = GameObject.Find("Player");
        SpawnCube();
    }

    // Update is called once per frame
    void Update()
    {
        toolNumber = WeaponControl.current;
        if (temp != toolNumber){
            temp = toolNumber;
            Debug.Log("Tool " +temp);
        }
        if (Input.GetMouseButtonDown(0) && !clear)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // && CurrentNumber == CubeType
                if (hit.collider.gameObject.tag == "Cube")
                {
                    CraftCube();
                }
            }
            if (clickCount == destroyThreshold)
            {
                if (currentLayer == cubeGameObjects.Length-1)
                {
                    cubeGameObjects[currentLayer].SetActive(false);
                    door.SetActive(true);
                }
                else
                {
                    cubeGameObjects[currentLayer].SetActive(false);
                    currentLayer++;
                    SpawnCube();
                }
                
            }
            
        }
    }

    void SpawnCube()
    {
        cubeGameObjects[currentLayer].SetActive(true);

        Debug.Log("Left Layer " + currentLayer);
        clickCount = 0;
    }

    void CraftCube()
    {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance < attackThreshold)
        {
            if (toolNumber == currentLayer)
            {
                clickCount++;
            }
        }
    }

}
