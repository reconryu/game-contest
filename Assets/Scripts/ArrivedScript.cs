using UnityEngine;
using System.Collections;

public class ArrivedScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		// Is this a shot?
		LeaveScript shot = otherCollider.gameObject.GetComponent<LeaveScript>();
		if (shot != null)
		{
			// Avoid friendly fire
			// Destroy the shot
			Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
				
		}
	}
}
