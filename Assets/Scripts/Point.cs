using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Point : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var text =  GetComponentInChildren<Text>();
        text.text = string.Format("x: {0}\ny: {1}\nz: {2}", transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.transform.LookAt(Camera.main.transform); 
	}
}
