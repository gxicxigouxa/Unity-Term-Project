﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Damage Text에 대한 Script.
/// </summary>
public class DamageTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

  // Update is called once per frame
  void Update() {
    TextUpdate();
  }

  //Text의 내용 Update.
  public void TextUpdate() {
    GetComponent<Text>().text = "피해량 : " + ObjectRemover.Damage;
  }
}
