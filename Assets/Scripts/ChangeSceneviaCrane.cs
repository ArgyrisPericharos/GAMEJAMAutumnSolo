using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if ((other.tag == "Player") && (Script.GetComponent<GameManager>().VeryImportantIsactive == true))
        {
            if ((Input.GetKeyDown("e")))
            {
                Debug.Log("Ready To change Scene");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
        }
            
    }
}
