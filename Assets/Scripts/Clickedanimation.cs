using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickedanimation : MonoBehaviour {
    public GameObject Text; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
  
	}
    private void OnMouseDown()
    {
        if (Text.activeSelf==true)
        {
            Text.SetActive(false);
        }
        else
        {
            Text.SetActive(true);
        }
    }
}
