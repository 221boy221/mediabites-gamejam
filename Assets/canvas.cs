using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class canvas : MonoBehaviour {

    public Text resource;
    public GameObject player;
    public Slider health;
    public GameObject Ltree;
    public GameObject tree;
    private PlayerResources _resources;
    private int upgradePrice = 25;

    void Start() {
        _resources = player.GetComponent<PlayerResources>();
    }

	void Update () 
    {
	    resource.text = player.GetComponent<PlayerResources>().leaves.ToString();
        health.value = tree.GetComponent<BigTree>().health;
	}

    public void grow()
    {
        if (_resources.leaves >= upgradePrice) {
            Ltree.SetActive(false);
            tree.SetActive(true);
            _resources.leaves -= upgradePrice;
        }
        
    }
}
