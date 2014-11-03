using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	private bool isTouched;
	public GameObject textLabel;
	public GameCtrlr gameController;
	// Use this for initialization
	void Start () {
		this.isTouched = false;

		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameCtrlr>();
		}
		if (gameController == null) {
			Debug.Log(" gameController is null ");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		if (this.isTouched) {
			return;
		}
		this.isTouched = true;

		iTween.RotateBy(gameObject, iTween.Hash(
			"x", 1, 
			"easeType", 
			"easeInOutBack", 
			"loopType", 
			"none", 
			"oncomplete", "OnMouseDownComplete"
			));
	}
	
	public virtual void OnMouseDownComplete(){
		this.isTouched = false;

	}
}
