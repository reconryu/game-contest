using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	GameObject mDdang01Obj;
	GameObject mDdang02Obj;

	// Use this for initialization
	void Start () {
		mDdang01Obj = GameObject.FindWithTag ("ddang01");
		mDdang02Obj = GameObject.FindWithTag ("ddang02");

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit = new RaycastHit();
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit)) {
					hit.transform.gameObject.SendMessage("OnMouseDown");
				}
			}
		}
	}

	void OnMouseDown() {
		touchAction();
	}

	private void touchAction() {
		Debug.Log("Down!!!!!!");
		Debug.Log("TAG:" + gameObject.tag);

		if (gameObject.tag == "ddang01") {

			SoldierScript soldier = GetComponent<SoldierScript>();
			if (soldier != null) {
				float ox = mDdang01Obj.transform.position.x;
				float oy = mDdang01Obj.transform.position.y;
				Debug.Log("ox = " + ox + ", y = " + oy);
				float dx = mDdang02Obj.transform.position.x;
				float dy = mDdang02Obj.transform.position.y;
				Debug.Log("dx = " + dx + ", dy = " + dy);

				float x = (dx - ox);
				float y = (dy - oy);


				Vector2 direction = new Vector2(x, y);
				soldier.Moving(direction);
			}
		}
	}

}
