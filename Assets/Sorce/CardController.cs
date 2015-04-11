using UnityEngine;
using System.Collections;

 [RequireComponent (typeof(Animator))]
public class CardController : MonoBehaviour {

	//private GameObject CardAnimate;
	private Animator animator;
	private int DrawCardId;
	private int DeleteCardId;

	public void init () {
		//CardAnimate = GameObject.Find ("101");
		animator = GetComponent<Animator> ();//アニメータを取得
		//各パラメーターのIDを取得
		DrawCardId = Animator.StringToHash ("DrawCard"); 
		DeleteCardId = Animator.StringToHash ("DeleteCard");
		//最初に１回引く
		DrawCard (true);
	}
		
	void initDeleteCard(){
		DeleteCard (false);
	}
	 
	//DrawCard制御関数
	public void DrawCard (bool chk){
		if (chk)
			animator.SetBool (DrawCardId, true);
		else
			animator.SetBool (DrawCardId, false);
	}

	public void DeleteCard (bool chk){
		if (chk)
			animator.SetBool (DeleteCardId, true);
		else
			animator.SetBool (DeleteCardId, false);
	}
		
}
