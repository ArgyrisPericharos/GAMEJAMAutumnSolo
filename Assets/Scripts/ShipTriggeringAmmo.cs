using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggeringAmmo : MonoBehaviour
{
    public GameObject Ammo;

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
        if (other.gameObject == Ammo)
        {
            Script.GetComponent<GameManager>().AmmoIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().AmmoIsactive = false;

    }



}
