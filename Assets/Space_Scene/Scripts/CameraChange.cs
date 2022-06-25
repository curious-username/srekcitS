using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private GameObject _cockpitView;
    private bool _changeView;
    private float MouseXInput, MouseYInput;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DefaultView());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _changeView = !_changeView;
        }

        if(_changeView == true)
        {
            _cockpitView.SetActive(false);
        }
        else
        {
            _cockpitView.SetActive(true);
        }
        MouseXInput = Input.GetAxis("Mouse X");
        MouseYInput = Input.GetAxis("Mouse Y");

    

            
    


    }

    private IEnumerator DefaultView()
    {
        //Need 5 second no touch rule to go back to default view
        while (true)
        {
            if (Input.anyKeyDown == false || MouseXInput == 0 || MouseYInput == 0)
            {
                yield return new WaitForSeconds(5.0f);
                _cockpitView.SetActive(false);
            }
        }
        
        
    }
}
