using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringRope : MonoBehaviour
{

    public GameObject Ropes;


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
        if (other.gameObject == Ropes)
        {
            Script.GetComponent<GameManager>().RopesIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().RopesIsactive = false;

    }



}
