using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aboveSphere : MonoBehaviour
{

    public GameObject text;
    //public GameObject obje;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.transform.LookAt(text.transform.position - Camera.main.transform.position);

    }
}
