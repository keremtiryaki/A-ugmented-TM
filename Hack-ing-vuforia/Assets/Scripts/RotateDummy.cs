using UnityEngine;
using System.Collections;

public class RotateDummy : MonoBehaviour {

	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("y", 1, "loopType", "loop", "easetype", "linear", "speed", 100));
	}
}
