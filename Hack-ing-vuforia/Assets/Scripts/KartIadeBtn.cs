using UnityEngine;
using System.Collections;

public class KartIadeBtn : Button {
	
	public override void OnMouseDownComplete(){
		base.OnMouseDownComplete ();
		this.gameController.showScreen1 ();
	}
}