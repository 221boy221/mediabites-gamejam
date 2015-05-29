using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class canvas : MonoBehaviour {
    public Text resource;
    public GameObject player;
	void Update () 
    {
	    resource.text = player.GetComponent<PlayerResources>().leaves.ToString();
	}
}
