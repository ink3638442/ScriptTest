using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {10, 20, 30, 40, 50};

		Debug.Log("/////一覧表示/////");
		for (int i = 0; i < array.Length; i++) {
			Debug.Log(array[i]);
		}

		Debug.Log("/////逆順表示/////");
		for (int i = array.Length - 1; i >= 0; i--) {
			Debug.Log(array[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
