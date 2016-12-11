using UnityEngine;
using System.Collections;

public class CameraOnMouse : MonoBehaviour {
    Vector2 mousePos;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePos, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -15f);
	}
}
