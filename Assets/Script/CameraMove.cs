using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Vector3     direction;
    private float       speed;

    public static CameraMove Instance;
	// Use this for initialization
	void Start () {
        direction = new Vector2(1,1);
        speed = 1;

        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.Failed)
        {
            return;
        }
        MoveForward(direction,speed);
    }

    void MoveForward(Vector3 dir,float speed) {
        transform.position += dir * Time.deltaTime*speed;
    }
}
