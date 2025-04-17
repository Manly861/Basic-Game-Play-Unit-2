using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float TimeStamp = 0f;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
            {
                if (TimeStamp < Time.time)
                {
                    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                    TimeStamp += 1f;
                }
                
            }

    }
}