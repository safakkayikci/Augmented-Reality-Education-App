using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour {

    public GameObject text;

    // Use this for initialization


    public AudioClip[] aClips;
    public AudioSource myAudioSource;

    string btnName;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        /*Debug.Log("1 left click.");
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            Debug.Log("2 left click.");

            if (Physics.Raycast(ray, out Hit)) {
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                Debug.Log("3 left click.");

            }
            }   
            */
    }

    void OnMouseDown() {
        if (text.activeSelf == true) {
            myAudioSource.clip = aClips[0];
            myAudioSource.Play();
            //Debug.Log("1 left click.");
            text.SetActive(false);

        } else {
            // Debug.Log("2 left click.");
            myAudioSource.clip = aClips[0];
            myAudioSource.Play();
            text.SetActive(true);
        }
    }
    
}
