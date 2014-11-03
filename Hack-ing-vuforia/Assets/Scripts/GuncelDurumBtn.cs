using UnityEngine;
using System.Collections;

public class GuncelDurumBtn : Button {

	public override void OnMouseDownComplete(){
		base.OnMouseDownComplete ();
		this.gameController.showGuncelDurum ();
	}
}
