using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 50f;
    private float _lowerBound = -20f;
    private float _sideBound = 30f;

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            //for projectiles, dont give damage
            Destroy(gameObject);
        } 
        else if (transform.position.z < _lowerBound)
        {
            DestroyAndGiveDamage();
        }
        else if (transform.position.x > _sideBound)
        {
            DestroyAndGiveDamage();
        }
        else if (transform.position.x < -_sideBound)
        {
            DestroyAndGiveDamage();
        }
    }

    private void DestroyAndGiveDamage()
    {
        _gameManager.AddLives(-1);
        Destroy(gameObject);
    }
}
