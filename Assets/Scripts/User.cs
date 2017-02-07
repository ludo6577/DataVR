using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class User : MonoBehaviour {

    [Header("Sensitivity")]
    public float RotationSensitivity;
    public float MoveSensitivity;
    
    [Header("Canvas")]
    public Text FloorIndicatorX;
    public Text FloorIndicatorXNeg;
    public Text FloorIndicatorZ;
    public Text FloorIndicatorZNeg;

    [Header("Prefabs")]
    public GameObject PointPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -RotationSensitivity);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, RotationSensitivity);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0f, 0f, MoveSensitivity));
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0f, 0f, -MoveSensitivity));

        FloorIndicatorX.text = transform.position.x.ToString();
        FloorIndicatorXNeg.text = (-transform.position.x).ToString();
        FloorIndicatorZ.text = transform.position.z.ToString();
        FloorIndicatorZNeg.text = (-transform.position.z).ToString();
	}
}
