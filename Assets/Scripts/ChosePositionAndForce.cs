using UnityEngine;
using System.Collections;

public class ChosePositionAndForce : MonoBehaviour {

	public GameObject Star;
	public iTween.EaseType easeType;
	public iTween.LoopType loopType;
	public float startPosition,endPosition;
	public float speed;
	// Use this for initialization
	void Start () {
		iTween.MoveTo (Star, iTween.Hash ("y", endPosition,"speed",speed,"EaseType",easeType,"LoopType",loopType));
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
