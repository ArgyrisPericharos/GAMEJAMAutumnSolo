using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneviaCrane : MonoBehaviour
{
    public GameManager Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Player" && Input.GetKeyDown("e")) && (Script.GetComponent<GameManager>().VeryImportantIsactive = true))
        {
            Debug.Log("Ready To change Scene");
        }
        else
            Debug.Log("Not Ready To change Scene");
    }
}
