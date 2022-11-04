using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccHitAudio : MonoBehaviour
{
    public GameObject audiosource;

    public GameObject Muzzle11;

    public GameManager gamemanager;
    //public CameraShake cameraShake;
    public GameObject Camshakeholder;
    public int State;

    private static float TimeRemaining = 10f;
    // Start is called before the first frame update
    void Start()
    {
        audiosource.SetActive(false);
        Muzzle11.SetActive(false);


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
            gamemanager.GetComponent<GameManager>().HitIsActive = true;
            Muzzle11.SetActive(true);

        }

        if ((TimeRemaining <= 3f) && (gamemanager.GetComponent<GameManager>().HitIsActive == true))
        {
            Debug.Log("I work 2");
            Camshakeholder.SetActive(true);
        }

        if (TimeRemaining < 0)
        {
            Debug.Log("I also work");
            gamemanager.GetComponent<GameManager>().HitIsActive = false;
            audiosource.SetActive(false);
            Camshakeholder.SetActive(false);
            Muzzle11.SetActive(false);

            State = 1;
        }
        if (State == 1)
        {
            TimeRemaining = 10f;
            State = 0;
        }
        
    }

}
