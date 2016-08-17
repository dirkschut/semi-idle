using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InterfaceManager : MonoBehaviour {

	private Player player;
	private Text coinsAmount;

	// Use this for initialization
	void Start () {
		player = new Player ();
		coinsAmount = GameObject.Find("Coins amount").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		player.coins++;
		coinsAmount.text = "Coins: " + player.coins;
	}
}
