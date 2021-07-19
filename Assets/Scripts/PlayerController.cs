using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _xRange = 20f;
    [SerializeField] private float _zRangeMax = 15.5f;
    [SerializeField] private float _zRangeMin = -1f;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _dotToAttack;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * _speed * _horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);

        if (transform.position.x < -_xRange)
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        if (transform.position.x  > _xRange)
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);

        if (transform.position.z < _zRangeMin)
            transform.position = new Vector3(transform.position.x, transform.position.y, _zRangeMin);
        if (transform.position.z > _zRangeMax)
            transform.position = new Vector3(transform.position.x, transform.position.y, _zRangeMax);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_projectile, _dotToAttack.position, _projectile.transform.rotation);       
        }
    }
}
