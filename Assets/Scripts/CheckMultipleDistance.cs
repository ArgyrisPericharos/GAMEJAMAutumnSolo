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

    private static float TimeRemaining = 12.5f;
    // Start is called before the first frame update
    void Start()
    {
        audiosource.SetActive(false);


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

        if (TimeRemaining <= 5f)
        {
            Debug.Log("I work1");
            audiosource.SetActive(true);
            gamemanager.GetComponent<GameManager>().MultipleDistanceIson = true;

        }

        if ((TimeRemaining <= 3f) && (gamemanager.GetComponent<GameManager>().MultipleDistanceIson == true))
        {
            Debug.Log("I work 2");
            // Camshakeholder.SetActive(true);
        }

        if (TimeRemaining < 0)
        {
            Debug.Log("I also work");
            gamemanager.GetComponent<GameManager>().MultipleDistanceIson = false;
            audiosource.SetActive(false);
            //Camshakeholder.SetActive(false);

            State = 1;
        }
        if (State == 1)
        {
            TimeRemaining = 12.5f;
            State = 0;
        }

    }
}
