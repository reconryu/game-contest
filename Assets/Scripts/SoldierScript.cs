using UnityEngine;
using System.Collections;

public class SoldierScript : MonoBehaviour {

	public Transform movePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Moving(Vector2 direction)
	{
		// Create a new shot 
		var moveTransform = Instantiate(movePrefab) as Transform;
		
		// Assign position
		moveTransform.position = transform.position;
		

		// Make the weapon shot always towards it
		MoveScript move = moveTransform.gameObject.GetComponent<MoveScript>();
		if (move != null)
		{
			//move.direction = this.transform.right; // towards in 2D space is the right of the sprite
			move.direction = direction;
		}
	}
}
