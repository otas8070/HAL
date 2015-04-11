using UnityEngine;
using System.Collections;

 [RequireComponent (typeof(Animator))]
public class CardController : MonoBehaviour {
 
	private Animator animator;
	private int DrawCardId;
	private int DeleteCardId;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> (); //アニメータを取得
		//各パラメーターのIDを取得
		DrawCardId = Animator.StringToHash ("DrawCard"); 
		DeleteCardId = Animator.StringToHash ("DeleteCard");
	}
	 
	// Update is called once per frame
	void Update () {
		//↑キーで制御
		if (Input.GetKey(KeyCode.UpArrow)) {
			DrawCard (true);
			DeleteCard (true);
		}else{
			DrawCard (false);
			DeleteCard (false);
		}
	} 

	//DrawCard制御関数
	void DrawCard (bool chk){
		if (chk)
			animator.SetBool (DrawCardId, true);
		else
			animator.SetBool (DrawCardId, false);
	}

	void DeleteCard (bool chk){
		if (chk)
			animator.SetBool (DeleteCardId, true);
		else
			animator.SetBool (DeleteCardId, false);
	}
}
