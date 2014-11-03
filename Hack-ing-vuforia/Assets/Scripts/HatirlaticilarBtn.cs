using UnityEngine;
using System.Collections;

public class HatirlaticilarBtn : Button {
	
	public override void OnMouseDownComplete(){
		base.OnMouseDownComplete ();
		this.gameController.showHatirlatici ();
	}
}
