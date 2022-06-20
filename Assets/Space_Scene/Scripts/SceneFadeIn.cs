using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneFadeIn : MonoBehaviour
{
    [SerializeField] private Image _blackOut;
    private float _alphaNum = 0;
    

    private void Start()
    {
        

            if (_blackOut != null)
            {
                _blackOut = GetComponent<Image>();
                StartCoroutine(Fade());
            }


    }

    private void Update()
    {
        _blackOut.color = new Color(0, 0, 0, _alphaNum);

    }

    private IEnumerator Fade()
    {
        while (true)
        {
            _alphaNum += 2f;
            yield return new WaitForSeconds(0.1f);
            
        }
        
    }


}
