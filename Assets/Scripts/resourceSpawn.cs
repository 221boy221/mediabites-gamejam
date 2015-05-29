using UnityEngine;
using System.Collections;

public class resourceSpawn : MonoBehaviour {

    public GameObject[] resources;
    public int amountResources;
	void Start () 
    {
        SpawnResources();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    private void SpawnResources()
    {
        for (int i = 0; i < amountResources; i++)
        {
            Vector3 loc = new Vector3(Random.Range(-50,50),Random.Range(-50,50),0);
            Instantiate(resources[Random.Range(0, resources.Length)], loc, transform.rotation);
        }
    }
}
