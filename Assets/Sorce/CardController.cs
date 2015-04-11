using UnityEngine;
using System.Collections;

 [RequireComponent (typeof(Animator))]
public class CardController : MonoBehaviour {
 
	private Animator animator;
	private int DrawCardId;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		DrawCardId = Animator.StringToHash ("DrawCard");
		Debug.Log (DrawCardId);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow)) {
			animator.SetBool(DrawCardId, true);
		}else{
			animator.SetBool(DrawCardId, false);
		}
	
	}
}
