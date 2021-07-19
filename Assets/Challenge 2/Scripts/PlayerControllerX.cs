using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeToSpawnDogMax = 3f;
    private float timeToSpawnDogCurrent;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (CanSpawnDog() == true))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        timeToSpawnDogCurrent -= Time.deltaTime;
    }

    private bool CanSpawnDog()
    {
        if (timeToSpawnDogCurrent <= 0)
        {
            timeToSpawnDogCurrent = timeToSpawnDogMax;
            return true;
        }
        else
        {
            return false;
        }
    }
}
