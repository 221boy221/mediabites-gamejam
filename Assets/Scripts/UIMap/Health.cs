using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    public Slider healthSlider;
    private float maxHp;
    private float curentHp;

	// Use this for initialization
	void Start () {
        maxHp = GameObject.FindGameObjectWithTag(Tags.PLAYER).GetComponent<PlayerBehaviour>().health;
        maxHp = 100;
        Debug.Log(maxHp);
	}
	
	// Update is called once per frame
	void Update () {
        
        healthSlider.maxValue = maxHp;
        healthSlider.value = curentHp;
	}
}
