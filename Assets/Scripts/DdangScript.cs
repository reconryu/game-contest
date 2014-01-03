using UnityEngine;
using System.Collections;


public class DdangScript : MonoBehaviour {

	public string tagName;

	// Use this for initialization
	void Start () {
		gameObject.tag = tagName;
	}
	
	// Update is called once per frame
	void Update () {

//		// touch 
//		//bool touch = Input.GetKey
//		// get a reference to the current event
//		bool shoot = Input.GetButtonDown("Fire1");
//		shoot |= Input.GetButtonDown("Fire2"); // For Mac users, ctrl + arrow is a bad idea
//		
//		if (shoot) {
//			// if right mouse button is pressed then we erase blocks
//			soldierCnt = soldierCnt - (decrease * 2);
//			SoldierScript soldier = GetComponent<SoldierScript>();
//			if (soldier != null) {
//				soldier.Moving(false);
//			}
//		}
	}



}
