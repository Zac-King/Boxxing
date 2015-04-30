using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public float Health;
    public float Mana;
    public float Stamina;

	// Use this for initialization
	void Start () {
	    Health  =  Mana  =  Stamina  =  100;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Health:  " + Health);
        //Debug.Log("Mana:    " + Mana);
        //Debug.Log("Stamina: " + Stamina);
	}
}
