using UnityEngine;
using System.Collections;

public class ParaYatirBtn : MonoBehaviour {

	private bool isTouched;
	private GameCtrlr gameController;
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameCtrlr>();
		}
		if (gameController == null) {
			Debug.Log(" gameController is null ");
		}
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
	
	void OnMouseDownComplete(){
		this.gameController.showParaYatirMenu ();
		this.isTouched = false;
	}
}
