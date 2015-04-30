using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    
    public GameObject pm; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            pm.GetComponent<PlayerManager>().takeDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            pm.GetComponent<PlayerManager>().giveMana(10);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            pm.GetComponent<PlayerManager>().loseStamina(5);
        }
        

    }
}
