using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvent : MonoBehaviour {

	RaycastHit _hit;
	Ray _ray;

	public GameObject firstGame;
    public GameObject secondGame;
    public GameObject thirdGame;
    public GameObject MainCube;
    public GameObject forthGame;
    public GameObject backButton;

    // Use this for initialization
    void Start () {
		firstGame.gameObject.SetActive(false);
        secondGame.gameObject.SetActive(false);
        thirdGame.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	    _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(_ray, out _hit)) {
			
			if (Input.GetMouseButtonDown(0))
			{
				if (_hit.collider.gameObject.name == "Option1") {
					// Write things you want to do when you click.
					Debug.Log("First option");
					if (firstGame.activeSelf == true) {
						firstGame.gameObject.SetActive(false);
                        secondGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                        forthGame.gameObject.SetActive(false);
                        
                    } else {
						firstGame.gameObject.SetActive(true);
					    secondGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                        forthGame.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(true);
                    }

				} else if (_hit.collider.gameObject.name == "Option2") {
					Debug.Log("Second option");
				    if (secondGame.activeSelf == true) {
				        secondGame.gameObject.SetActive(false);
				        firstGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                        forthGame.gameObject.SetActive(false);
                    } else {
				        secondGame.gameObject.SetActive(true);
				        firstGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                        forthGame.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(true);
                    }

                } else if (_hit.collider.gameObject.name == "Option3") {
					Debug.Log("Third option");
                    if (thirdGame.activeSelf == true)
                    {
                        secondGame.gameObject.SetActive(false);
                        firstGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                        MainCube.gameObject.SetActive(true);
                        forthGame.gameObject.SetActive(false);

                    }
                    else
                    {
                        
                        thirdGame.gameObject.SetActive(true);
                        firstGame.gameObject.SetActive(false);
                        secondGame.gameObject.SetActive(false);
                        MainCube.gameObject.SetActive(false);
                        forthGame.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(true);

                    }
                }
                else if (_hit.collider.gameObject.name == "Option4")
                {
                    Debug.Log("Forth option");
                    if (forthGame.activeSelf == true)

                    {
                        forthGame.gameObject.SetActive(false);
                        secondGame.gameObject.SetActive(false);
                        firstGame.gameObject.SetActive(false);
                        thirdGame.gameObject.SetActive(false);
                       

                    }
                    else
                    {
                        forthGame.gameObject.SetActive(true);
                        thirdGame.gameObject.SetActive(false);
                        firstGame.gameObject.SetActive(false);
                        secondGame.gameObject.SetActive(false);
                        backButton.gameObject.SetActive(true);


                    }
                }

            }
				
		}
	}
}
