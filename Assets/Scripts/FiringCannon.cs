using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringCannon : MonoBehaviour
{
    public GameObject Toactivate1;
    public GameObject Toactivate2;
    public GameObject Toactivate3;
    // Start is called before the first frame update
    void Start()
    {
        Toactivate1.SetActive(false);
        Toactivate2.SetActive(false);
        Toactivate3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I am Inside");

            if ((Input.GetKeyDown("e")))
            {
                Debug.Log("I fired the cannon");
                Toactivate1.SetActive(true);
                Toactivate2.SetActive(true);
                Toactivate3.SetActive(true);
            }
           
        }
    }
}
