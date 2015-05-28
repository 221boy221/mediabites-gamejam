using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

    [SerializeField]
    private GameObject panel;
    [SerializeField]
    private GameObject UIPanel;
    [SerializeField]
    private GameObject UpgradeButton;
	void Update () 
    {

        if (Input.GetKeyDown("e") && panel.active == false)
        {
            panel.SetActive(true);
        }
        else if (Input.GetKeyDown("e") && panel.active == true)
        {
            panel.SetActive(false);
            UpgradeButton.SetActive(true);
            UIPanel.SetActive(false);

        }
    }

    public void OpenShop()
    {
        Debug.Log("openshop");
        if (UIPanel.active == true)
        {
            UIPanel.SetActive(false);
            UpgradeButton.SetActive(true);
        }

        else if(UIPanel.active == false)
        {
            UIPanel.SetActive(true);
            UpgradeButton.SetActive(false);            
        }
    }
}