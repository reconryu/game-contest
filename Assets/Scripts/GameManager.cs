using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	int increaseValue = 50;

	private bool isDragging = false;
	public Transform ddangPrefab;

	// Use this for initialization
	void Start () {

		Camera.main.transparencySortMode = TransparencySortMode.Orthographic;

		//GameObject sDdang = (GameObject)Instantiate(Resources.Load("Ddang"));
		//sDdang.tag = "ddang01";

		var ddangTransform = Instantiate(ddangPrefab) as Transform;
		ddangTransform.position = transform.position;
		ddangTransform.position = new Vector3(-3.0f, 0, 0);
		ddangTransform.tag = "ddang01";

		var ddangTransform2 = Instantiate(ddangPrefab) as Transform;
		ddangTransform2.position = transform.position;
		ddangTransform2.position = new Vector3(3.0f, 4.0f, 0);
		ddangTransform2.tag = "ddang02";

	}

	// Update is called once per frame
	void Update () {
		updateTouchEvent ();
	}



	void updateTouchEvent() {
		RaycastHit hit = new RaycastHit();
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit)) {
					hit.transform.gameObject.SendMessage("OnMouseDown");
				}
			} else if (Input.GetTouch(i).phase.Equals(TouchPhase.Moved)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit)) {
					hit.transform.gameObject.SendMessage("OnMouseDrag");
				}
			} else if (Input.GetTouch(i).phase.Equals(TouchPhase.Ended)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit)) {
					hit.transform.gameObject.SendMessage("OnMouseUp");
				}
			}
		}
	}

	public void setEndOfDragging() {
		isDragging = false;
	}

	private Vector2 touchStartPosition = Vector2.zero;
	private Vector2 touchEndPosition   = Vector2.zero;
	
	void OnMouseDrag() {
		Debug.Log("GameManager: OnMouseDrag");

		touchEndPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		
		if (touchEndPosition.x != touchStartPosition.x || touchEndPosition.y != touchStartPosition.y) {

		}
	}
	
	void OnMouseDown() {
		Debug.Log("GameManager: OnMouseDown");
		
		touchStartPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
	}
	
	void OnMouseUp() {

		if (touchEndPosition.x != touchStartPosition.x || touchEndPosition.y != touchStartPosition.y) {
			Debug.Log("GameManager: DRAGGGGGG");
			
		} else {
			Debug.Log("GameManager: DOWNNNNNN");
		}

	}

	void OnTriggerEnter2D(Collider2D col2d) {
		Debug.Log("GameManager: OnTriggerEnter2D");

	}
	
	void OnTriggerExit2D(Collider2D col2d) {
		Debug.Log("GameManager: OnTriggerExit2D:" + col2d.GetType());
	}
}
