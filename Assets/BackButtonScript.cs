using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{

    RaycastHit _hit;
    Ray _ray;

    public GameObject backButton;
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;
    public GameObject game4;
    public GameObject mainCube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {
            if (_hit.collider.gameObject.name == "backButton")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (game1.gameObject.activeSelf == true)
                    {
                        mainCube.gameObject.SetActive(true);
                        game1.gameObject.SetActive(false);
                        game2.gameObject.SetActive(false);
                        game3.gameObject.SetActive(false);
                        game4.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(false);


                    }
                    else if (game2.gameObject.activeSelf == true)
                    {
                        mainCube.gameObject.SetActive(true);
                        game1.gameObject.SetActive(false);
                        game2.gameObject.SetActive(false);
                        game3.gameObject.SetActive(false);
                        game4.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(false);
                    }
                    else if (game3.gameObject.activeSelf == true)
                    {
                        mainCube.gameObject.SetActive(true);
                        game1.SetActive(false);
                        game2.SetActive(false);
                        game3.SetActive(false);
                        game4.SetActive(false);
                        backButton.gameObject.SetActive(false);
                    }
                    else if (game4.gameObject.activeSelf == true)
                    {
                        mainCube.gameObject.SetActive(true);
                        game1.SetActive(false);
                        game2.SetActive(false);
                        game3.SetActive(false);
                        game4.SetActive(false);
                        backButton.gameObject.SetActive(false);
                    }


                }

            }
        }
    }
}