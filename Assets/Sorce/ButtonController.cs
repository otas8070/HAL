using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent (typeof(Animator))]
public class ButtonController : MonoBehaviour {

	private CardController CardControl;

	void Start () {
		GameObject go = GameObject.Find ("101");
		CardControl = go.GetComponent<CardController>();
		CardControl.init ();
	}

	public void ClickHi (){
		CardControl.DeleteCard (true);
	}

	public void yahoo (){
		Debug.Log ("yahoo!");
	}
		
}
