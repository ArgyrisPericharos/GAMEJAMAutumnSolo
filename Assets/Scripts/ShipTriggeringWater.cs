using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringWater : MonoBehaviour
{

    public GameObject Water;


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
        if (other.gameObject == Water)
        {
            Script.GetComponent<GameManager>().WaterIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().WaterIsactive = false;

    }



}
