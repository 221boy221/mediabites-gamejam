using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class canvas : MonoBehaviour {
    public Text resource;
    public GameObject player;
    public Slider health;
    public BigTree tree;
	void Update () 
    {
	    resource.text = player.GetComponent<PlayerResources>().leaves.ToString();
        health.value = tree.helth;
	}
}
