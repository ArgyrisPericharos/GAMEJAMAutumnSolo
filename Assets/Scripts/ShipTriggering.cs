using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTriggering : MonoBehaviour
{
    public GameObject Wood;
    public GameObject Food;
    public GameObject Ammo;
    public GameObject VeryImportant;
    public GameObject Water;
    public GameObject Ropes;
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
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Wood)
        {
            Script.GetComponent<GameManager>().WoodIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().WoodIsactive = false;

        if (other.gameObject == Food)
        {
            Script.GetComponent<GameManager>().FoodIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().FoodIsactive = false;

        if (other.gameObject == Ammo)
        {
            Script.GetComponent<GameManager>().AmmoIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().AmmoIsactive = false;

        if (other.gameObject == VeryImportant)
        {
            Script.GetComponent<GameManager>().VeryImportantIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().VeryImportantIsactive = false;

        if (other.gameObject == Water)
        {
            Script.GetComponent<GameManager>().WaterIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().WaterIsactive = false;

        if (other.gameObject == Ropes)
        {
            Script.GetComponent<GameManager>().RopesIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().RopesIsactive = false;

        if (other.gameObject == Nav)
        {
            Script.GetComponent<GameManager>().NavIsactive = true;
        }
        else
            Script.GetComponent<GameManager>().NavIsactive = false;
    }
}
