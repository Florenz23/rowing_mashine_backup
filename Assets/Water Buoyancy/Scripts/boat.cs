using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using UnityEngine.UI;


public class boat : MonoBehaviour {

    public float turnSpeed = 1000f;
    public float accellerateSpeed = 1000f;
    public Text player_speed_text;

    private Rigidbody rbody;
    private double speed;

    public Texture BoxTexture;              // Drag a Texture onto this item in the Inspector

        GUIContent content;
        GUIStyle style = new GUIStyle();

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        // Position the Text in the center of the Box
        style.alignment = TextAnchor.MiddleCenter;
        style.fontSize = 50;

      }

	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0f);
        rbody.AddForce(transform.forward * v * accellerateSpeed * Time.deltaTime);
        speed = rbody.velocity.magnitude;
	}
  void FixedUpdated(){
        // speed = rigidbody.velocity.magnitude;
        print("Hello World!");
  }
  void OnGUI(){

        // Displays 1.6E+20.
        speed = Math.Round(speed, 2);
        // speed = string.Format("{00:00}", speed);
        GUI.Box(new Rect(50, 50, Screen.width/3, Screen.height/4), "Me: " + speed + " km/h", style);
        // GUI.Box(new Rect(50, 50, Screen.width/3+20, Screen.height/4+20), " " + speed, style);
  }
}
