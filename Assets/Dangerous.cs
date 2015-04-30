using UnityEngine;
using System.Collections;

public class Dangerous : MonoBehaviour {
    
    public GameObject pm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
        void onTriggerEnter()
        {
            pm.GetComponent<PlayerManager>().takeDamage(10);
        }
	}
}
