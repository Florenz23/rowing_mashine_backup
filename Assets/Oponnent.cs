using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;

public class Oponnent : MonoBehaviour
{

    public float accellerateSpeed = 1000f;
    public float speed = 0.5f;
    private double speed_opp;

    public Texture BoxTexture;              // Drag a Texture onto this item in the Inspector

        GUIContent content;
        GUIStyle style = new GUIStyle();

    private Rigidbody rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        style.alignment = TextAnchor.MiddleCenter;
        style.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        rbody.AddForce(transform.forward * speed * accellerateSpeed * Time.deltaTime);
        speed_opp = rbody.velocity.magnitude;
    }
    void OnGUI(){

          // Displays 1.6E+20.
          speed_opp = Math.Round(speed_opp, 2);
          // speed = string.Format("{00:00}", speed);
          GUI.Box(new Rect(50, 50, Screen.width/3+900, Screen.height/4), "Günni: " + speed_opp + " km/h", style);
          // GUI.Box(new Rect(50, 50, Screen.width/3+20, Screen.height/4+20), " " + speed, style);
    }
}
