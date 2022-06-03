using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Sounds : MonoBehaviour
    
{
    [SerializeField] private AudioSource _selectionSound, _startGameSound;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void selectionSound()
    {
        _selectionSound.Play();
    }
    
    public void startGameSound()
    {
        _startGameSound.Play();
    }
}
