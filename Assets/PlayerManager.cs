using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(float dmg){
        player.GetComponent<PlayerStats>().Health -= dmg;
    }
    public void giveMana(float manaup)
    {
        player.GetComponent<PlayerStats>().Mana += manaup;
    }
    public void loseStamina(float b)
    {
        player.GetComponent<PlayerStats>().Stamina -= b;
    }
    

}
