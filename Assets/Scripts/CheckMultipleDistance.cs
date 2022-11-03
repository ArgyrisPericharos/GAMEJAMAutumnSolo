using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMultipleDistance : MonoBehaviour
{
    public GameObject audiosource;

    public GameManager gamemanager;
    //public CameraShake cameraShake;
    //public GameObject Camshakeholder;
    public int State;

    public GameObject Muzzle1, Muzzle2, Muzzle4, Muzzle3, Muzzle5, Muzzle6, Muzzle7, Muzzle8, Muzzle9, Muzzle10;

    public GameObject Smoke1, Smoke2, Smoke3;


    private static float TimeRemaining = 20f;
    // Start is called before the first frame update
    void Start()
    {
        audiosource.SetActive(false);

        Muzzle1.SetActive(false);
        Muzzle2.SetActive(false);
        Muzzle3.SetActive(false);
        Muzzle4.SetActive(false);
        Muzzle5.SetActive(false);
        Muzzle6.SetActive(false);
        Muzzle7.SetActive(false);
        Muzzle8.SetActive(false);
        Muzzle9.SetActive(false);
        Muzzle10.SetActive(false);

        Smoke1.SetActive(false);
        Smoke2.SetActive(false);
        Smoke3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (State == 0)
        {
            if (TimeRemaining > 0f)
            {
                TimeRemaining -= Time.deltaTime;
            }
            else State = 1;
        }

        if (TimeRemaining <= 12f)
        {
            Debug.Log("I work1");
            audiosource.SetActive(true);
            gamemanager.GetComponent<GameManager>().MultipleDistanceIson = true;
            Muzzle1.SetActive(true);
        }
        if (TimeRemaining <= 11f)
        {
            Muzzle2.SetActive(true);
        }
        if (TimeRemaining <= 10f)
        {
            Muzzle3.SetActive(true);
        }
        if (TimeRemaining <= 9f)
        {
            Muzzle5.SetActive(true);
        }
        if (TimeRemaining <= 8f)
        {
            Muzzle7.SetActive(true);
        }
        if (TimeRemaining <= 7f)
        {
            Muzzle8.SetActive(true);
        }
        if (TimeRemaining <= 6f)
        {
            Muzzle9.SetActive(true);
        }
        if (TimeRemaining <= 5f)
        {
            Muzzle4.SetActive(true);
        }
        if (TimeRemaining <= 4f)
        {
            Muzzle6.SetActive(true);
        }
        if (TimeRemaining <= 3f)
        {
            Muzzle6.SetActive(true);
        }



        if (TimeRemaining < 0)
        {
            Debug.Log("I also work");
            gamemanager.GetComponent<GameManager>().MultipleDistanceIson = false;
            audiosource.SetActive(false);
            //Camshakeholder.SetActive(false);
            Muzzle1.SetActive(false);
            Muzzle2.SetActive(false);
            Muzzle3.SetActive(false);
            Muzzle4.SetActive(false);
            Muzzle5.SetActive(false);
            Muzzle6.SetActive(false);
            Muzzle7.SetActive(false);
            Muzzle8.SetActive(false);
            Muzzle9.SetActive(false);
            Muzzle10.SetActive(false);

            Smoke1.SetActive(true);
            Smoke2.SetActive(true);
            Smoke3.SetActive(true);

            State = 1;
        }
        if (State == 1)
        {
            TimeRemaining = 12.5f;
            State = 0;
        }

    }
}
