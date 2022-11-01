using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringFood : MonoBehaviour
{
    public GameObject Food;


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


        if (other.gameObject == Food)
        {
            Script.GetComponent<GameManager>().FoodIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().FoodIsactive = false;

     
    }



}
