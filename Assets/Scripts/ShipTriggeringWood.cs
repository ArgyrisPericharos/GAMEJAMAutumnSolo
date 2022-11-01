using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringWood : MonoBehaviour
{
    public GameObject Wood;


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
        if (other.gameObject == Wood)
        {
            Script.GetComponent<GameManager>().WoodIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().WoodIsactive = false;

    }



}
