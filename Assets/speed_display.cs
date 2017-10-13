using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class speed_display : MonoBehaviour {

	public Text txt;
     private int currentscore=0;
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
    txt.text="Score : " + currentscore;

	}

	// Update is called once per frame
	void Update () {

	}
}
