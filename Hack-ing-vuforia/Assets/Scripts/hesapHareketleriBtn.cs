using UnityEngine;
using System.Collections;

public class hesapHareketleriBtn : Button {
	
	public override void OnMouseDownComplete(){
		base.OnMouseDownComplete ();
		this.gameController.showHesapHareketleri();
	}
}
