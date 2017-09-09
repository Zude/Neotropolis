﻿/*************************************************************
* Anzeigen eines Prefabs (ToolTip), wenn man Collider entert * 
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour {
	public GameObject myPrefab;
	private GameObject myObject;
	public string myString; 


	void OnTriggerEnter2D(Collider2D other){
		
		myObject=Instantiate(myPrefab); 
		myObject.transform.SetParent(transform);

		myObject.GetComponentInChildren<Text> ().text = myString;

	}

	void OnTriggerExit2D(Collider2D other){
		Destroy (myObject);
	}
}