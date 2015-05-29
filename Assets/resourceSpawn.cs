using UnityEngine;
using System.Collections;

public class resourceSpawner : MonoBehaviour {

    public GameObject[] resources;
    public int amountResources;
    private float timeStarted;
	void Start () 
    {
        timeStarted = Time.deltaTime;
        SpawnResources();
	}
	
	// Update is called once per frame
	void Update () 
    {
	if(Time.deltaTime <= timeStarted + 2)
    {
        timeStarted = Time.deltaTime;
        SpawnResources();
    }
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
