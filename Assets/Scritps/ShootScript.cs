using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Camera arCamera;
    public GameObject popSoundObject;
    public static int score;

    public void Shoot()
    {
        RaycastHit hit;
        if( Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(popSoundObject);
                score++;
                TimerScript.timeLeft += 2.0f;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
