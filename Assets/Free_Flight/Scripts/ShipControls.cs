using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    [SerializeField] private float _rotSpeed = 50, _moveSpeed = 50, _currentSpeed, _maxRotate;
    private float _vertical, _horizontal;
    [SerializeField] private GameObject _shipModel;
    
    
    //[SerializeField] private float _moveSpeed;
    //[SerializeField] private float _currentSpeed;
    //private float _horizontal;
    //[SerializeField] private float _maxRotate;
    // Start is called before the first frame update


    void Start()
    {
        _currentSpeed = 25;
    }

    void Update()
    {
        ShipMovement();
    }

    private void ShipMovement()
    {
        _vertical = Input.GetAxis("Vertical");
        _horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.T))
        {
            _currentSpeed++;
            if (_currentSpeed > 49)
            {
                _currentSpeed = 50;
            }
        }//increase speed

        if (Input.GetKeyDown(KeyCode.G))
        {
            _currentSpeed--;
            if (_currentSpeed < 1)
            {
                _currentSpeed = 0;
            }
        }//decrease speed

        Vector3 rotateH = new Vector3(0, _horizontal, 0);
        transform.Rotate(rotateH * _rotSpeed * Time.deltaTime);

        Vector3 rotateV = new Vector3(_vertical, 0, 0);
        transform.Rotate(rotateV * _rotSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, 0, _horizontal * 0.2f), Space.Self);

        transform.position += transform.right * _currentSpeed * Time.deltaTime;
    }
}
