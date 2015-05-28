using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

    [SerializeField]
    private GameObject panel;
	void Update () 
    {	
        if(Input.GetKeyDown("e") && panel.active == false)
        {
            panel.SetActive(true);
        }
        else if (Input.GetKeyDown("e") && panel.active == true)
        {
            panel.SetActive(false);
        }
    }
}