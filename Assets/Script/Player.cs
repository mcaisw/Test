using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour {
    public static Player Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.Failed)
        {
            return;
        }
        if (DistanceToCamera_X()>3)
        {
            GameManager.Instance.CallFailedUi();
        }
	}

    public void Jump(Vector3 endValue,float jumpPower,int numJumps,float duration,bool snapping) {
        Debug.Log("player jump");
        transform.DOJump(endValue,jumpPower,numJumps,duration,snapping).OnComplete(()=> {
            GameInput.Instance.PlayerCanJump();
        });
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="red")
        {
            Debug.Log("失败");
            GameManager.Instance.CallFailedUi();
        }
    }

    float DistanceToCamera_X() {
        return  CameraMove.Instance.transform.position.x- transform.position.x;
    }

}
