using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringNav : MonoBehaviour
{

    public GameObject Nav;

    public GameManager Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Nav)
        {
            Script.GetComponent<GameManager>().NavIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().NavIsactive = false;
    }



}
