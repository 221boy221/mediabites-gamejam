using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    public Slider healthSlider;
    public int maxHp;
    public int curentHp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        healthSlider.maxValue = maxHp;
        healthSlider.value = curentHp;
	}
}
