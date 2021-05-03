using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject emotionGroup;

    private RaycastHit _hit;
    private Ray _ray;

    private GameObject selectedEmotionGameObject;

    private int selectedObject;

    void Start()
    {
        selectedEmotionGameObject = emotionGroup.gameObject.transform.GetChild(0).gameObject;
        selectedObject = 0;
    }


    void Update()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (_hit.collider.gameObject.name == "PrevSphere")
                {
                    Debug.Log("Clicked to prev button");
                    selectedEmotionGameObject.gameObject.SetActive(false);

                    selectedObject--;

                    if (selectedObject <= -1)
                    {
                       selectedObject = 2;
                   }
                    selectedEmotionGameObject = emotionGroup.gameObject.transform.GetChild(selectedObject).gameObject;      
                    selectedEmotionGameObject.gameObject.SetActive(true);
                    //selectedEmotionGameObject.gameObject.transform.position = new Vector3(0, 1, 0);


                }
                else if (_hit.collider.gameObject.name == "NextSphere")
                {
                    Debug.Log("Clicked to next button");
                    selectedEmotionGameObject.gameObject.SetActive(false);

                    selectedObject = selectedObject + 1;
                    if (selectedObject >= 3)
                    {
                        selectedObject = 0;
                    }
                    selectedEmotionGameObject = emotionGroup.gameObject.transform.GetChild(selectedObject).gameObject;
                    selectedEmotionGameObject.gameObject.SetActive(true);
                    //selectedEmotionGameObject.gameObject.transform.position = new Vector3(0, 1, 0);

                }

            }

        }
    }
}


