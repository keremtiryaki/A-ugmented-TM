using UnityEngine;
using System.Collections;

public class GameCtrlr : MonoBehaviour {

	public GameObject directLight;

	public GameObject imageTarget;
	public GameObject screen1;
	public GameObject menuScreen;
	public GameObject paraCekScreen;
	public GameObject paraYatirScreen;
	public GameObject guncelDurum;
	public GameObject hesapHareketleri;
	public GameObject hatirlaticiScreen;


	private bool isScreenMoving = false;
	private GameObject currentScreen;
	private int countOfPass = 0;
	private Quaternion mainCamQuaternion = new Quaternion (0f,0f,0f,1f);



	void Start(){
		this.directLight.GetComponent<Light> ().light.color = new Color ( 1F,	0.3F,	0F);
		GameObject cloneObj = Instantiate(this.screen1, new Vector3(-20000f, 0f, 0f), mainCamQuaternion) as GameObject;
		cloneObj.transform.parent = this.imageTarget.transform;
		cloneObj.transform.localScale = new Vector3(0.000577f, 0.000577f, 0.000577f);
		iTween.MoveBy(cloneObj, iTween.Hash("x", 20000, "easeType", "easeInOutExpo", "loopType", "none"));
		this.currentScreen = cloneObj;
	}
//	public void hideObject(GameObject obj){
//		Debug.Log ("hideObject");
//		//obj.renderer.enabled = false;
//	}
	// Update is called once per frame
	void Update () {
	}

	public void increaseCountOfPass(){
		this.countOfPass = this.countOfPass + 1;
		if (this.countOfPass > 3) {
			this.showScreen(this.menuScreen);
		}
	}

	public void moveAndDestroyObject(GameObject obj){
		iTween.MoveBy(obj, iTween.Hash("x", 20000, "easeType", "easeInOutExpo", "loopType", "none"
//		                               , "oncomplete", "hideObject", "oncompleteparams", obj,
//		                               "oncompletetarget", this.gameObject
		                               ));
	}

	public void showScreen(GameObject screen){

		if (this.isScreenMoving) {
			return;
		}

		this.isScreenMoving = true;

		this.moveAndDestroyObject(this.currentScreen);
		GameObject cloneObj = Instantiate(screen, new Vector3(-20000f, 0f, 0f), mainCamQuaternion) as GameObject;
		cloneObj.transform.parent = this.imageTarget.transform;
		cloneObj.transform.localScale = new Vector3(0.000577f, 0.000577f, 0.000577f);
		iTween.MoveBy(cloneObj, iTween.Hash("x", 20000, "easeType", "easeInOutExpo", "loopType", "none"
		                                    , "oncomplete", "showScreenComplete",
		                                    "oncompletetarget", this.gameObject
		                                    ));
		this.currentScreen = cloneObj;
	}

	public void showScreenComplete(){
		this.isScreenMoving = false;
	}

	public void showParaCekMenu(){
		this.showScreen(this.paraCekScreen);
	}

	public void showParaYatirMenu(){
		this.showScreen(this.paraYatirScreen);
	}
	
	public void showMenu(){
		this.showScreen(this.menuScreen);
	}

	public void showGuncelDurum(){
		this.showScreen(this.guncelDurum);
	}
	
	public void showHesapHareketleri(){
		this.showScreen(this.hesapHareketleri);
	}
	public void showScreen1(){
		this.showScreen(this.screen1);
	}

	public void showHatirlatici(){
		this.showScreen(this.hatirlaticiScreen);
	}

}
