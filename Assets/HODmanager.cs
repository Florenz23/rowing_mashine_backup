using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HODmanager : MonoBehaviour {
	public Text name_text;
	public TextMesh d_text;
	// Name get goes here!
	private string testName = "Günni";

	// Use this for initialization
	void Start () {
		name_text.text = "Name: " +testName;
		d_text.text = "Name: " +testName;

	}

	// Update is called once per frame
	void Update () {

	}
}
